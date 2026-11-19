using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Examination.Api;

public static class ExaminationEndpoints
{
    public static IEndpointRouteBuilder MapExaminationEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/api/examination/_placeholder", () =>
                Results.Problem("Examination endpoints are scaffolded but not implemented.", statusCode: 501))
            .WithTags("Examination");
        return endpoints;
    }
}
