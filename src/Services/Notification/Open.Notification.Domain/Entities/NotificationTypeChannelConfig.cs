namespace Open.Notification.Domain.Entities;

public class NotificationTypeChannelConfig
{
    public Guid Id { get; set; }
    public Guid NotificationTypeChannelId { get; set; }
    public int Enabled { get; set; }
}
