﻿namespace E_commerce_API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null) 
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
            // "??" this is null coalescing operator, this means if left side value is null then execute right side value
        }

        public int StatusCode {  get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request, you have made",
                401 => "Authorized, you are not",
                404 => "Resource found, it was not",
                500 => "Error are the path of learning",
                _ => null, // symbol _ means default
            };
        }

    }
}
