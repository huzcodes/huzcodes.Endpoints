using huzcodes.Endpoints.Abstractions;
using huzcodes.Endpoints.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace huzcodes.Endpoints.API.Endpoints.MultiSourceTests
{
    public class MultiSourceTests : EndpointsAsync
                                    .WithRequest<MultiSourceTestsRequest>
                                    .WithActionResult<MultiSourceTestsResponse>
    {
        [HttpPost(MultiSourceTestsRequest.Route)]
        public async override Task<ActionResult<MultiSourceTestsResponse>> HandleAsync([FromMultiSource] MultiSourceTestsRequest request, CancellationToken cancellationToken = default)
        {
            // we are using this empty task only to avoid the warning for the green line of the async
            await Task.CompletedTask;

            if (request.srcName == "huzcodes")
                return Ok(new MultiSourceTestsResponse()
                {
                    AddedName = request.RequestBody.Name,
                    AddedValue = request.RequestBody.Value,
                    AddedQuery = !string.IsNullOrEmpty(request.QueryName) ? request.QueryName : "not provided"
                });

            return BadRequest("must provide route parameter value as expected");
        }
    }
}
