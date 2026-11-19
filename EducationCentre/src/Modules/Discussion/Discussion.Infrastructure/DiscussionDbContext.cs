using Microsoft.EntityFrameworkCore;

namespace Discussion.Infrastructure;

public sealed class DiscussionDbContext(DbContextOptions<DiscussionDbContext> options)
    : DbContext(options)
{
}
