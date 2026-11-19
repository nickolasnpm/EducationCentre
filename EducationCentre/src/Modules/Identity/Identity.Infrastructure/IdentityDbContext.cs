using Microsoft.EntityFrameworkCore;

namespace Identity.Infrastructure;

public sealed class IdentityDbContext(DbContextOptions<IdentityDbContext> options)
    : DbContext(options)
{
}
