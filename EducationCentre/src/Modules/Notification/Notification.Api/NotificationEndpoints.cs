using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Notification.Api;

public static class NotificationEndpoints
{
    public static IEndpointRouteBuilder MapNotificationEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/api/notifications/_placeholder", () =>
                Results.Problem("Notification endpoints are scaffolded but not implemented.", statusCode: 501))
            .WithTags("Notification");
        return endpoints;
    }
}
