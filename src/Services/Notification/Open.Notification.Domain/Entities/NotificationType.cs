namespace Open.Notification.Domain.Entities;

public class NotificationType
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid GroupId { get; set; }
    public int Status { get; set; }
}
