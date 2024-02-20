# huzcodes.Endpoints

huzcodes.Endpointsis is a C# .NET 8 package designed to facilitate the implementation of the REPR design pattern. It provides four abstract classes for creating endpoints, two without authorization ('**EndpointsSync**' and '**EndpointsAsync**'), and two with authorization ('**AuthorizedEndpointsSync**' and '**AuthorizedEndpointsAsync**'). These classes offer a structured approach to defining endpoints, handling requests and responses, and integrating authorization using JWT tokens.

The package includes several features to simplify endpoint development, including support for:

- Creating endpoints with request and response classe.
- Handling synchronous and asynchronous operations.
- Structured response handling with or without ActionResult.
- Creating endpoints with or without a request, and similarly, with or without a response.
- Multi-source parameter binding (from body, query, and route).
- File extension validation for uploaded files.

### Installation

To install huzcodes.Endpoints, use the following command in the Package Manager Console:

```bash

dotnet add package huzcodes.Endpoints--version 1.0.0
```

### Usage

To use huzcodes.Endpoints, follow these steps:

- Create request and response classes for your endpoints.
- Inherit from the appropriate abstract classes provided by the package ('**EndpointsSync**', '**EndpointsAsync**', '**AuthorizedEndpointsSync**', '**AuthorizedEndpointsAsync**').
- Implement the HandleAsync method to define the logic of your endpoint.

<br>

Here's an example of how you can use '**EndpointsAsync**' with request and response classes:

```csharp

// Define request class
public class MyRequest
{
    // Request properties
}

// Define response class
public class MyResponse
{
    // Response properties
}

// Define endpoint class
public class MyEndpoint : EndpointsAsync
                          .WithRequest<MyRequest>
                          .WithActionResult<MyResponse>
{
    [HttpPost("/myEndpoint")]
    public async override Task<ActionResult<MyResponse>> HandleAsync(MyRequest request, CancellationToken cancellationToken = default)
    {
        // Endpoint logic
    }
}

```

<br>

And below is an example demonstrating the usage of '**EndpointsAsync**' along with the '**FromMultiSource**' attribute, showcasing request and response classes:

```csharp
// Request class with parameters from body, query, and route
public class MultiSourceRequest
{
    public const string Route = "/multiSource/{id}";

    [FromRoute]
    public int Id { get; set; }

    [FromQuery]
    public string QueryParam { get; set; }

    [FromBody]
    public RequestBody Body { get; set; }

    public class RequestBody
    {
        public string Name { get; set; }
    }
}

// Response class
public class MultiSourceResponse
{
    public int Id { get; set; }
    public string QueryParam { get; set; }
    public string BodyName { get; set; }
}

// Endpoint class using EndpointsAsync
public class MultiSourceEndpoint : EndpointsAsync
                                    .WithRequest<MultiSourceRequest>
                                    .WithActionResult<MultiSourceResponse>
{
    [HttpPost(MultiSourceRequest.Route)]
    public async override Task<ActionResult<MultiSourceResponse>> HandleAsync([FromMultiSource] MultiSourceRequest request, CancellationToken cancellationToken = default)
    {
        await Task.CompletedTask;

        return Ok(new MultiSourceResponse
        {
            Id = request.Id,
            QueryParam = request.QueryParam,
            BodyName = request.Body.Name
        });
    }
}
```

<br>

For more information on how to use huzcodes.Endpoints, please refer to the [API Package Tests](https://github.com/huzcodes/huzcodes.Endpoints/tree/main/huzcodes.Endpoints.API).

### Contributing

Contributions are welcome! Please fork the repository and submit a pull request.

### License

This project is licensed under the MIT License - see the [LICENSE.md](https://github.com/huzcodes/huzcodes.Endpoints/blob/main/LICENSE) file for details.
