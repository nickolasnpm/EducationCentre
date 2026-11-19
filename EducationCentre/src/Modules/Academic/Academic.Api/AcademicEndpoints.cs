using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Academic.Api;

public static class AcademicEndpoints
{
    public static IEndpointRouteBuilder MapAcademicEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/api/academic/_placeholder", () =>
                Results.Problem("Academic endpoints are scaffolded but not implemented.", statusCode: 501))
            .WithTags("Academic");
        return endpoints;
    }
}
