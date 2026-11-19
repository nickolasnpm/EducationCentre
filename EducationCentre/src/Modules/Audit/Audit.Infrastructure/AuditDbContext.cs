using Microsoft.EntityFrameworkCore;

namespace Audit.Infrastructure;

public sealed class AuditDbContext(DbContextOptions<AuditDbContext> options)
    : DbContext(options)
{
}
