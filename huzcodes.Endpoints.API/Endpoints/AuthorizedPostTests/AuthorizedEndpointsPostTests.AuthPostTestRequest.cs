using Microsoft.AspNetCore.Mvc;

namespace huzcodes.Endpoints.API.Endpoints.AuthorizedPostTests
{
    public class AuthPostTestRequest
    {
        public const string Route = "/authPostTests";
        [FromBody]
        public AuthRequestBody RequestBody { get; set; } = new();
    }

    public class AuthRequestBody
    {
        public string Name { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }
}
