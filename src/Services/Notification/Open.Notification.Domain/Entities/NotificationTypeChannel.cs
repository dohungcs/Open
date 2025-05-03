namespace Open.Notification.Domain.Entities;

public class NotificationTypeChannel
{
    public Guid Id { get; set; }
    public Guid NotificationTypeId { get; set; }
    public int Channel { get; set; }
    public int Enabled { get; set; }
}
