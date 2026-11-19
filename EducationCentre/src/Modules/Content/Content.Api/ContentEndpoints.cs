using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Content.Api;

public static class ContentEndpoints
{
    public static IEndpointRouteBuilder MapContentEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/api/content/_placeholder", () =>
                Results.Problem("Content endpoints are scaffolded but not implemented.", statusCode: 501))
            .WithTags("Content");
        return endpoints;
    }
}
