using Microsoft.AspNetCore.Mvc;

namespace huzcodes.Endpoints.API.Endpoints.MultiSourceTests
{
    public class MultiSourceTestsRequest
    {
        public const string Route = "/multiSourcePostTests/{srcName}";

        [FromRoute]
        public string srcName { get; set; } = string.Empty;
        [FromQuery]
        public string QueryName { get; set; } = string.Empty;
        [FromBody]
        public MultiSourceRequestBody RequestBody { get; set; } = new();
    }

    public class MultiSourceRequestBody
    {
        public string Name { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }
}
