using Discussion.Realtime;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Discussion.Api;

public static class DiscussionEndpoints
{
    public static IEndpointRouteBuilder MapDiscussionEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/api/discussion/_placeholder", () =>
                Results.Problem("Discussion endpoints are scaffolded but not implemented.", statusCode: 501))
            .WithTags("Discussion");
        endpoints.MapHub<DiscussionHub>("/hubs/discussion");
        return endpoints;
    }
}
