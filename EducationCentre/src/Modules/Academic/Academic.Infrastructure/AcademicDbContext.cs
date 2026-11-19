using Microsoft.EntityFrameworkCore;

namespace Academic.Infrastructure;

public sealed class AcademicDbContext(DbContextOptions<AcademicDbContext> options)
    : DbContext(options)
{
}
