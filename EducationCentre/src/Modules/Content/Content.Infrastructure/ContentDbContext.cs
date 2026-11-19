using Microsoft.EntityFrameworkCore;

namespace Content.Infrastructure;

public sealed class ContentDbContext(DbContextOptions<ContentDbContext> options)
    : DbContext(options)
{
}
