using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Attendance.Api;

public static class AttendanceEndpoints
{
    public static IEndpointRouteBuilder MapAttendanceEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/api/attendance/_placeholder", () =>
                Results.Problem("Attendance endpoints are scaffolded but not implemented.", statusCode: 501))
            .WithTags("Attendance");
        return endpoints;
    }
}
