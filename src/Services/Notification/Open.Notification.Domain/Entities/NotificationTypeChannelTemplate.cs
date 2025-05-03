namespace Open.Notification.Domain.Entities;

public class NotificationTypeChannelTemplate
{
    public Guid Id { get; set; }
    public Guid NotificationTypeChannelId {get; set; }
    public Guid TemplateId { get; set; }
}
