using huzcodes.Endpoints.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace huzcodes.Endpoints.Abstractions
{
    [Authorize]
    public static class AuthorizedEndpointsSync
    {
        [Authorize]
        public static class WithRequest<TRequest>
        {
            public abstract class WithResult<TResponse> : AuthorizedEndpointsBase
            {
                public abstract TResponse Handle(TRequest request);
            }

            public abstract class WithoutResult : AuthorizedEndpointsBase
            {
                public abstract void Handle(TRequest request);
            }

            public abstract class WithActionResult<TResponse> : AuthorizedEndpointsBase
            {
                public abstract ActionResult<TResponse> Handle(TRequest request);
            }

            public abstract class WithActionResult : AuthorizedEndpointsBase
            {
                public abstract ActionResult Handle(TRequest request);
            }
        }

        [Authorize]
        public static class WithoutRequest
        {
            public abstract class WithResult<TResponse> : AuthorizedEndpointsBase
            {
                public abstract TResponse Handle();
            }

            public abstract class WithoutResult : AuthorizedEndpointsBase
            {
                public abstract void Handle();
            }

            public abstract class WithActionResult<TResponse> : AuthorizedEndpointsBase
            {
                public abstract ActionResult<TResponse> Handle();
            }

            public abstract class WithActionResult : AuthorizedEndpointsBase
            {
                public abstract ActionResult Handle();
            }
        }
    }
}
