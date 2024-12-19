namespace WeatherApp.Models
{
    public class WeatherModel
    {
        public Location location { get; set; }
        public Current current { get; set; }

        public Historical historical { get; set; }

        public Forecast forecast { get; set; }
    }

    public class Location
    {
        public string name { get; set; }
        public string country { get; set; }
        public string region { get; set; }
        public string localtime { get; set; }
    }

    public class Current
    {
        public int temperature { get; set; }
        public string[] weather_descriptions { get; set; }
    }

    public class Historical
    {
        public string date { get; set; }
        public int mintemp { get; set; }
        public int maxtemp { get; set; }
        public double avgtemp { get; set; }
        public int uv_index { get; set; }
    }

    public class Forecast
    {
        public string date { get; set; }
        public int mintemp { get; set; }
        public int maxtemp { get; set; }
        public double avgtemp { get; set; }
        public int uv_index { get; set; }
    }
}
