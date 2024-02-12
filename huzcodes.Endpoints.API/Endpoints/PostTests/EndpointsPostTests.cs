using huzcodes.Endpoints.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace huzcodes.Endpoints.API.Endpoints.PostTests
{
    public class EndpointsPostTests : EndpointsAsync
                                     .WithRequest<PostTestRequest>
                                     .WithActionResult<PostTestResponse>
    {
        [HttpPost(PostTestRequest.Route)]
        public async override Task<ActionResult<PostTestResponse>> HandleAsync(PostTestRequest request, CancellationToken cancellationToken = default)
        {
            // we are using this empty task only to avoid the warning for the green line of the async
            await Task.CompletedTask;

            return Ok(new PostTestResponse()
            {
                AddedName = request.RequestBody.Name,
                AddedValue = request.RequestBody.Value
            });
        }
    }
}
