using Microsoft.EntityFrameworkCore;

namespace Notification.Infrastructure;

public sealed class NotificationDbContext(DbContextOptions<NotificationDbContext> options)
    : DbContext(options)
{
}
