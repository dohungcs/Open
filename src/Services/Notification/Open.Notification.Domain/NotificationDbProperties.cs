namespace Open.Notification.Domain;

public static class NotificationDbProperties
{
    public static string DbTablePrefix { get; set; } = "OpenNotificationService";

    public static string DbSchema { get; set; } = null!;

    public const string ConnectionStringName = "OpenNotificationService";
    
}
