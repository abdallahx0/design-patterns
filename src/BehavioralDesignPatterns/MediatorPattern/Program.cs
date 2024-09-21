using MediatorPattern;

IChatMediator chatMediator = new ChatManagement();

User ahmed = new User("Ahmed", chatMediator);
User ali = new User("Ali", chatMediator);
User mohamed = new User("Mohamed", chatMediator);


chatMediator.RegisterUserToGroup(ahmed, "Development");
chatMediator.RegisterUserToGroup(ali, "Development");
chatMediator.RegisterUserToGroup(mohamed, "Development");

ahmed.SendGroupMessage("Message Group", "Development");
ahmed.SendDirectMessage("Hello Ali", ali);