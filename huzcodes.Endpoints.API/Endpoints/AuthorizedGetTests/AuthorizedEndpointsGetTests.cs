using huzcodes.Endpoints.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace huzcodes.Endpoints.API.Endpoints.AuthorizedGetTests
{
    public class AuthorizedEndpointsGetTests : AuthorizedEndpointsAsync
                                              .WithoutRequest
                                              .WithActionResult<AuthGetTestsResponse>

    {
        [HttpGet(AuthGetTestsRequest.Route)]
        public async override Task<ActionResult<AuthGetTestsResponse>> HandleAsync(CancellationToken cancellationToken = default)
        {
            // we are using this empty task only to avoid the warning for the green line of the async
            await Task.CompletedTask;

            return Ok(new AuthGetTestsResponse()
            {
                Name = "huzcodes",
                Value = "Endpoints"
            });
        }
    }
}
