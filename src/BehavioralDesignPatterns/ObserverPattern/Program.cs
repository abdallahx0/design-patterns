
using ObserverPattern;

User user1 = new User("User1");
User user2 = new User("User2");

Newsletter newsletter = new Newsletter();

newsletter.Subscribe(user1);
newsletter.Subscribe(user2);

newsletter.SendNotification("New blog post published!");
newsletter.Unsubscribe(user1);
newsletter.SendNotification("Another blog post published!");