using Academic.Api;
using Attendance.Api;
using Audit.Api;
using Content.Api;
using Discussion.Api;
using Examination.Api;
using Identity.Api;
using Notification.Api;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddSignalR();

var allowedOrigins = builder.Configuration.GetSection("Cors:AllowedOrigins").Get<string[]>() ?? [];
builder.Services.AddCors(options =>
    options.AddPolicy("Frontends", policy => policy
        .WithOrigins(allowedOrigins)
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials()));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();
app.UseCors("Frontends");
app.MapGet("/health", () => Results.Ok(new { status = "ok" }));
app.MapIdentityEndpoints();
app.MapAcademicEndpoints();
app.MapAttendanceEndpoints();
app.MapExaminationEndpoints();
app.MapDiscussionEndpoints();
app.MapNotificationEndpoints();
app.MapAuditEndpoints();
app.MapContentEndpoints();

app.Run();
