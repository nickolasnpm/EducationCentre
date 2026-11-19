namespace Notification.Contracts;

public interface INotificationSender
{
    Task SendAsync(string recipientId, string subject, string message, CancellationToken cancellationToken);
}
