using Microsoft.AspNetCore.Mvc;

namespace huzcodes.Endpoints.API.Endpoints.PostTests
{
    public class PostTestRequest
    {
        public const string Route = "/postTests";
        [FromBody]
        public RequestBody RequestBody { get; set; } = new();
    }

    public class RequestBody
    {
        public string Name { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }
}
