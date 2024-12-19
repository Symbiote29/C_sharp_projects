using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CurrentWeatherDisplay()
        {
            return View("CurrentWeatherDisplay");
        }

        [HttpPost]
        public async Task<IActionResult> GetCurrentWeatherDetails(string location, string viewName)
        {
            WeatherService weatherService = new WeatherService();
            var response = await weatherService.GetCurrentWeatherData(location);

            if (response.isSuccess)
            {
                return View(viewName, response.jsonData);
            }
            else
            {
                ViewData["Message"] = response.message;
                return View(viewName);
            }
        }

        public IActionResult HistoricalWeatherDisplay()
        {
            return View("HistoricalWeatherDisplay");
        }

        public async Task<IActionResult> GetHistoricalWeatherDetails(string location, string viewName, DateTime historicalDate, int hourly)
        {
            WeatherService weatherService = new WeatherService();
            var response = await weatherService.GetHistoricalWeatherData(location, historicalDate, hourly);

            if (response != null)
            {
                _logger.LogInformation("Response is not null." + response);
                var responseJson = JsonSerializer.Serialize(response, new JsonSerializerOptions { WriteIndented = true });
                _logger.LogInformation($"Response JSON: {responseJson}");

                var jsonData = response.jsonData;

                if (jsonData != null)
                {
                    _logger.LogInformation("Response contains valid data.");
                    return View(viewName, jsonData);
                }
                else
                {
                    _logger.LogWarning("No data found for the provided location and date.");
                    ViewData["Message"] = "No data found for this location and date.";
                    return View(viewName);
                }
            }
            else
            {
                _logger.LogError("Response is null. Error message: {Message}", response?.message);
                ViewData["Message"] = response?.message ?? "An unexpected error occurred.";
                return View("HistoricalWeatherDisplay");
            }
        }

        public IActionResult ForecastWeatherDisplay()
        {
            return View("ForecastWeatherDisplay");
        }

        public async Task<IActionResult> GetForecastWeatherDetails(string location, string viewName, int forecastDays, int hourly)
        {
            _logger.LogInformation("location: " + location);
            _logger.LogInformation("viewName: " + viewName);
            _logger.LogInformation("forecast days: " + forecastDays);
            _logger.LogInformation("hourly: " + hourly);

            WeatherService weatherService = new WeatherService();
            var response = await weatherService.GetForecastWeatherData(location, forecastDays, hourly);

            if (response != null)
            {
                _logger.LogInformation("Response is not null." + response);
                var responseJson = JsonSerializer.Serialize(response, new JsonSerializerOptions { WriteIndented = true });
                _logger.LogInformation($"Response JSON: {responseJson}");


                var jsonData = response.jsonData;

                if (jsonData != null)
                {
                    _logger.LogInformation("Response contains valid data.");
                    return View(viewName, jsonData);
                }
                else
                {
                    _logger.LogWarning("No data found for the provided location and date.");
                    ViewData["Message"] = "No data found for this location and date.";
                    return View(viewName);
                }
            }
            else
            {
                _logger.LogError("Response is null. Error message: {Message}", response?.message);
                ViewData["Message"] = response?.message ?? "An unexpected error occurred.";
                return View("ForecastWeatherDisplay");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult CurrentWeatherDisplayPartial()
        {
            return View("CurrentWeatherDisplay");
        }

        public IActionResult HistoricalWeatherDisplayPartial()
        {
            return View("HistoricalWeatherDisplay");
        }

        public IActionResult ForecastWeatherDisplayPartial()
        {
            return View("ForecastWeatherDisplay");
        }
    }
}
