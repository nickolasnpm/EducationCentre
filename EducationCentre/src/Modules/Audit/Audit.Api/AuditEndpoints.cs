using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Audit.Api;

public static class AuditEndpoints
{
    public static IEndpointRouteBuilder MapAuditEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/api/audit/_placeholder", () =>
                Results.Problem("Audit endpoints are scaffolded but not implemented.", statusCode: 501))
            .WithTags("Audit");
        return endpoints;
    }
}
