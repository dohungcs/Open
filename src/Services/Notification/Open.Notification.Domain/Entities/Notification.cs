using Open.Notification.Domain.Enums;

namespace Open.Notification.Domain.Entities;

public class Notification
{
    public Guid Id { get; set; }
    public string UserId { get; set; }
    public Guid NotificationTypeId { get; set; }
    public int ChannelId { get; set; }
    public Guid AppId { get; set; }
    public Guid NotificationGroupId { get; set; }
    public string Subject { get; set; }
    public string Content { get; set; }
    public NotificationStatus Status { get; set; }
}
