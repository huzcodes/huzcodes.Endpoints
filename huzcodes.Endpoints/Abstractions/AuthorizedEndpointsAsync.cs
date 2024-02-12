using huzcodes.Endpoints.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace huzcodes.Endpoints.Abstractions
{
    [Authorize]
    public static class AuthorizedEndpointsAsync
    {
        [Authorize]
        public static class WithRequest<TRequest>
        {
            public abstract class WithResult<TResponse> : AuthorizedEndpointsBase
            {
                public abstract Task<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken = default);
            }

            public abstract class WithoutResult : AuthorizedEndpointsBase
            {
                public abstract Task HandleAsync(TRequest request, CancellationToken cancellationToken = default);
            }

            public abstract class WithActionResult<TResponse> : AuthorizedEndpointsBase
            {
                public abstract Task<ActionResult<TResponse>> HandleAsync(TRequest request, CancellationToken cancellationToken = default);
            }

            public abstract class WithActionResult : AuthorizedEndpointsBase
            {
                public abstract Task<ActionResult> HandleAsync(TRequest request, CancellationToken cancellationToken = default);
            }

            public abstract class WithAsyncEnumerableResult<T> : AuthorizedEndpointsBase
            {
                public abstract IAsyncEnumerable<T> HandleAsync(TRequest request, CancellationToken cancellationToken = default);
            }
        }

        [Authorize]
        public static class WithoutRequest
        {
            public abstract class WithResult<TResponse> : AuthorizedEndpointsBase
            {
                public abstract Task<TResponse> HandleAsync(CancellationToken cancellationToken = default);
            }

            public abstract class WithoutResult : AuthorizedEndpointsBase
            {
                public abstract Task HandleAsync(CancellationToken cancellationToken = default);
            }

            public abstract class WithActionResult<TResponse> : AuthorizedEndpointsBase
            {
                public abstract Task<ActionResult<TResponse>> HandleAsync(CancellationToken cancellationToken = default);
            }

            public abstract class WithActionResult : AuthorizedEndpointsBase
            {
                public abstract Task<ActionResult> HandleAsync(CancellationToken cancellationToken = default);
            }

            public abstract class WithAsyncEnumerableResult<T> : AuthorizedEndpointsBase
            {
                public abstract IAsyncEnumerable<T> HandleAsync(CancellationToken cancellationToken = default);
            }
        }
    }
}
