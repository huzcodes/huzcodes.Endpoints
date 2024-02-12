using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace huzcodes.Endpoints.Base
{
    [ApiController]
    [Authorize]
    public abstract class AuthorizedEndpointsBase : ControllerBase
    {
    }
}
