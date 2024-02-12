using huzcodes.Endpoints.Base;
using Microsoft.AspNetCore.Mvc;

namespace huzcodes.Endpoints.Abstractions
{
    public static class EndpointsAsync
    {
        public static class WithRequest<TRequest>
        {
            public abstract class WithResult<TResponse> : EndpointsBase
            {
                public abstract Task<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken = default);
            }

            public abstract class WithoutResult : EndpointsBase
            {
                public abstract Task HandleAsync(TRequest request, CancellationToken cancellationToken = default);
            }

            public abstract class WithActionResult<TResponse> : EndpointsBase
            {
                public abstract Task<ActionResult<TResponse>> HandleAsync(TRequest request, CancellationToken cancellationToken = default);
            }

            public abstract class WithActionResult : EndpointsBase
            {
                public abstract Task<ActionResult> HandleAsync(TRequest request, CancellationToken cancellationToken = default);
            }

            public abstract class WithAsyncEnumerableResult<T> : EndpointsBase
            {
                public abstract IAsyncEnumerable<T> HandleAsync(TRequest request, CancellationToken cancellationToken = default);
            }
        }

        public static class WithoutRequest
        {
            public abstract class WithResult<TResponse> : EndpointsBase
            {
                public abstract Task<TResponse> HandleAsync(CancellationToken cancellationToken = default);
            }

            public abstract class WithoutResult : EndpointsBase
            {
                public abstract Task HandleAsync(CancellationToken cancellationToken = default);
            }

            public abstract class WithActionResult<TResponse> : EndpointsBase
            {
                public abstract Task<ActionResult<TResponse>> HandleAsync(CancellationToken cancellationToken = default);
            }

            public abstract class WithActionResult : EndpointsBase
            {
                public abstract Task<ActionResult> HandleAsync(CancellationToken cancellationToken = default);
            }

            public abstract class WithAsyncEnumerableResult<T> : EndpointsBase
            {
                public abstract IAsyncEnumerable<T> HandleAsync(CancellationToken cancellationToken = default);
            }
        }
    }
}
