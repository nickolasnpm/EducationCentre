using Microsoft.EntityFrameworkCore;

namespace Attendance.Infrastructure;

public sealed class AttendanceDbContext(DbContextOptions<AttendanceDbContext> options)
    : DbContext(options)
{
}
