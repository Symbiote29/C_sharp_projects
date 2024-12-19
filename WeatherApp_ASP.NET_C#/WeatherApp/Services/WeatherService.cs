using Flurl.Http;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public class WeatherService
    {
        public async Task<ResponseModel> GetCurrentWeatherData(string location)
        {
            string currentWeathereatherApiUrl = AppConstants.currentWeatherApiUrl;
            string weatherApiKey = AppConstants.weatherApiKey;

            string apiUrl = $"{currentWeathereatherApiUrl}?access_key={weatherApiKey}&query={location}";

            try
            {
                Console.WriteLine($"API URL: {apiUrl}");
                var response = await apiUrl.GetAsync();
                if (response.StatusCode == 200)
                {
                    var responseData = await response.GetJsonAsync<WeatherModel>();
                    return ResponseModel.Sucess(responseData);
                }
                return ResponseModel.Error(response.ResponseMessage.ToString());
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ResponseModel>();
                return errorResponse;
            }
        }

        public async Task<ResponseModel> GetHistoricalWeatherData(string location, DateTime historicalDate, int hourly)
        {
            string historicalWeatherApiUrl = AppConstants.historicalWeatherApiUrl;
            string weatherApiKey = AppConstants.weatherApiKey;

            string apiUrl = $"{historicalWeatherApiUrl}?access_key={weatherApiKey}&query={location}&historical_date={historicalDate:yyyy-MM-dd}&hourly={hourly}";

            try
            {
                Console.WriteLine($"API URL: {apiUrl}");

                var response = await apiUrl.GetAsync();
                Console.WriteLine($"Response Status Code: {response.StatusCode}");

                var rawResponse = await response.GetStringAsync();
                Console.WriteLine($"Raw Response: {rawResponse}");

                if (response.StatusCode == 200)
                {
                    var responseData = await response.GetJsonAsync<WeatherModel>();
                    var historicalData = responseData?.historical;

                    if (historicalData != null && historicalData.date == historicalDate.ToString("yyyy-MM-dd"))
                    {
                        return ResponseModel.Sucess(historicalData);
                    }
                    else
                    {
                        Console.WriteLine("No matching historical data found for the given date.");
                        return ResponseModel.Error("Historical data not found for the provided date.");
                    }
                }
                else
                {
                    Console.WriteLine($"Unexpected status code: {response.StatusCode}");
                    return ResponseModel.Error($"Unexpected status code: {response.StatusCode}");
                }
            }
            catch (FlurlHttpException ex)
            {
                Console.WriteLine($"FlurlHttpException: {ex.Message}");
                var errorResponse = await ex.GetResponseStringAsync();
                Console.WriteLine($"Raw Error Response: {errorResponse}");
                return ResponseModel.Error("An error occurred while fetching historical weather data.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Exception: {ex.Message}");
                return ResponseModel.Error("An error occurred while fetching historical weather data.");
            }
        }

        public async Task<ResponseModel> GetForecastWeatherData(string location, int forecastDays, int hourly)
        {
            string forecastWeatherApiUrl = AppConstants.forecastWeatherApiUrl;
            string weatherApiKey = AppConstants.weatherApiKey;

            string apiUrl = $"{forecastWeatherApiUrl}?access_key={weatherApiKey}&query={location}&forecast_days={forecastDays}&hourly={hourly}";

            Console.WriteLine($"API URL: {apiUrl}");

            try
            {
                var response = await apiUrl.GetAsync();

                Console.WriteLine($"Response Status Code: {response.StatusCode}");
                var rawResponse = await response.GetStringAsync();
                Console.WriteLine($"Raw Response: {rawResponse}");

                if (response.StatusCode == 200)
                {
                    var responseData = await response.GetJsonAsync<WeatherModel>();
                    var forecastData = responseData?.forecast;

                    if (forecastData != null)
                    {
                        return ResponseModel.Sucess(forecastData);
                    }
                    else
                    {
                        Console.WriteLine("No matching forecast data found for the given date.");
                        return ResponseModel.Error("forecast data not found for the provided date.");
                    }
                }
                else
                {
                    Console.WriteLine($"Unexpected status code: {response.StatusCode}");
                    return ResponseModel.Error($"Unexpected status code: {response.StatusCode}");
                }
            }
            catch (FlurlHttpException ex)
            {
                Console.WriteLine($"FlurlHttpException: {ex.Message}");
                var errorResponse = await ex.GetResponseStringAsync();
                Console.WriteLine($"Raw Error Response: {errorResponse}");
                return ResponseModel.Error("An error occurred while fetching forecast weather data.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Exception: {ex.Message}");
                return ResponseModel.Error("An error occurred while fetching forecast weather data.");
            }
        }
    }
}
