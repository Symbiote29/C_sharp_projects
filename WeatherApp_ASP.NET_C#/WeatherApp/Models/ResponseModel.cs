namespace WeatherApp.Models
{
    public class ResponseModel
    {
        public bool isSuccess { get; set; }
        public String? message { get; set; }
        public object? jsonData { get; set; }

        public static ResponseModel Sucess(dynamic jsonData)
        {
            return new ResponseModel
            {
                jsonData = jsonData,
                message = null,
                isSuccess = true
            };
        }

        public static ResponseModel Error(string errorMessage)
        {
            return new ResponseModel()
            {
                jsonData = null,
                message = errorMessage,
                isSuccess = false
            };
        }
    }
}