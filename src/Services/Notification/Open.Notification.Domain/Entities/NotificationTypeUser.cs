namespace Open.Notification.Domain.Entities;

public class NotificationTypeUser
{
    public Guid Id { get; set; }
    public Guid NotificationTypeId { get; set; }
    public int Channel { get; set; }
    public int Enabled { get; set; }
    public Guid? UserId { get; set; }
}
