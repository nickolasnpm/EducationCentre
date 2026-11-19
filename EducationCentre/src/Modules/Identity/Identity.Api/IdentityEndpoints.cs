using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Identity.Api;

public static class IdentityEndpoints
{
    public static IEndpointRouteBuilder MapIdentityEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/api/identity/_placeholder", () =>
                Results.Problem("Identity endpoints are scaffolded but not implemented.", statusCode: 501))
            .WithTags("Identity");
        return endpoints;
    }
}
