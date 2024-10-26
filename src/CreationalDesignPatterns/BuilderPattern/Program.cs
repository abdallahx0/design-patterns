using BuilderPattern;

MessengerNotification notificationBuilder = new MessengerNotificationBuilder()
    .SetTheme("Dark")
    .SetContent("Set content")
    .SetAttachments(new List<string>() { "image.png" })
    .SetRecipient("ali")
    .SetSender("ahmed")
    .SetTimestamp("2025-12-25 11:00")
    .Build();

Console.WriteLine($"Content: {notificationBuilder.Content}");
Console.WriteLine($"Sender: {notificationBuilder.Sender}");
Console.WriteLine($"Recipient: {notificationBuilder.Recipient}");
Console.WriteLine($"Timestamp: {notificationBuilder.Timestamp}");
Console.WriteLine($"Attachments: {notificationBuilder.Attachments}");
Console.WriteLine($"Theme: {notificationBuilder.Theme}");