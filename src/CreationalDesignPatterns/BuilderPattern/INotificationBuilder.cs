namespace BuilderPattern
{
    public interface INotificationBuilder
    {
        INotificationBuilder SetContent(string content);
        INotificationBuilder SetSender(string sender);
        INotificationBuilder SetRecipient(string recipient);
        INotificationBuilder SetTimestamp(string timestamp);
        INotificationBuilder SetAttachments(List<string> attachments);
        INotificationBuilder SetTheme(string theme);
        MessengerNotification Build();
    }
}
