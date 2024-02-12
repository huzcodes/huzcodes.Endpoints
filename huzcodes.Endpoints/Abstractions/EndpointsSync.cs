using huzcodes.Endpoints.Base;
using Microsoft.AspNetCore.Mvc;

namespace huzcodes.Endpoints.Abstractions
{
    public static class EndpointsSync
    {
        public static class WithRequest<TRequest>
        {
            public abstract class WithResult<TResponse> : EndpointsBase
            {
                public abstract TResponse Handle(TRequest request);
            }

            public abstract class WithoutResult : EndpointsBase
            {
                public abstract void Handle(TRequest request);
            }

            public abstract class WithActionResult<TResponse> : EndpointsBase
            {
                public abstract ActionResult<TResponse> Handle(TRequest request);
            }

            public abstract class WithActionResult : EndpointsBase
            {
                public abstract ActionResult Handle(TRequest request);
            }
        }

        public static class WithoutRequest
        {
            public abstract class WithResult<TResponse> : EndpointsBase
            {
                public abstract TResponse Handle();
            }

            public abstract class WithoutResult : EndpointsBase
            {
                public abstract void Handle();
            }

            public abstract class WithActionResult<TResponse> : EndpointsBase
            {
                public abstract ActionResult<TResponse> Handle();
            }

            public abstract class WithActionResult : EndpointsBase
            {
                public abstract ActionResult Handle();
            }
        }
    }
}
