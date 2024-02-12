using huzcodes.Endpoints.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace huzcodes.Endpoints.API.Endpoints.GetTests
{
    public class EndpointsGetTests : EndpointsAsync
                                    .WithoutRequest
                                    .WithActionResult<GetTestsResponse>

    {
        [HttpGet(GetTestsRequest.Route)]
        public async override Task<ActionResult<GetTestsResponse>> HandleAsync(CancellationToken cancellationToken = default)
        {
            // we are using this empty task only to avoid the warning for the green line of the async
            await Task.CompletedTask;

            return Ok(new GetTestsResponse()
            {
                Name = "huzcodes",
                Value = "Endpoints"
            });
        }
    }
}
