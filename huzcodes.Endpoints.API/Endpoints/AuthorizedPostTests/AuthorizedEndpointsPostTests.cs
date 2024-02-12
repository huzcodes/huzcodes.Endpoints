using huzcodes.Endpoints.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace huzcodes.Endpoints.API.Endpoints.AuthorizedPostTests
{
    public class AuthorizedEndpointsPostTests : AuthorizedEndpointsAsync
                                               .WithRequest<AuthPostTestRequest>
                                               .WithActionResult<AuthPostTestResponse>
    {
        [HttpPost(AuthPostTestRequest.Route)]
        public async override Task<ActionResult<AuthPostTestResponse>> HandleAsync(AuthPostTestRequest request, CancellationToken cancellationToken = default)
        {
            // we are using this empty task only to avoid the warning for the green line of the async
            await Task.CompletedTask;

            return Ok(new AuthPostTestResponse()
            {
                AddedName = request.RequestBody.Name,
                AddedValue = request.RequestBody.Value
            });
        }
    }
}
