using Newtonsoft.Json;

namespace CefSharp.RequestIntercept.Schema
{
    public class Response
    {
        [JsonProperty("schemaName")]
        public string SchemaName { get; set; }
        [JsonProperty("statusCode")]
        public string StatusCode { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public string Data { get; set; }

        public static Response Success(string schemaName, string data)
        {
            return new Response()
            {
                SchemaName = schemaName,
                StatusCode = "0",
                Message = null,
                Data = data
            };
        }

        public static Response Fail(string schemaName, string message, string statusCode = "-1")
        {
            return new Response()
            {
                SchemaName = schemaName,
                StatusCode = statusCode,
                Message = message,
                Data = null
            };
        }

        public string ToJsonString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}