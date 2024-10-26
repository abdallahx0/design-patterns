namespace BuilderPattern
{
    public class MessengerNotification
    {
        public string Content { get; }
        public string Sender { get; }
        public string Recipient { get; }
        public string Timestamp { get; }
        public List<string> Attachments { get; }
        public string Theme { get; }

        internal MessengerNotification(MessengerNotificationBuilder builder)
        {
            Content = builder.Content;
            Sender = builder.Sender;
            Recipient = builder.Recipient;
            Timestamp = builder.Timestamp;
            Attachments = builder.Attachments;
            Theme = builder.Theme;
        }
    }
}
