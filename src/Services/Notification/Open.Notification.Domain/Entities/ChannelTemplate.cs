namespace Open.Notification.Domain.Entities;

public class ChannelTemplate
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public Guid LanguageId { get; set; }
    public int Channel { get; set; }
    public string Subject { get; set; }
    public string Content { get; set; }
    public string FileUrl { get; set; }
}
