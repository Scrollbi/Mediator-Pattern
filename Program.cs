using Mediator_Pattern;

public interface IChatMediator
{
    void SendMessage(string message, User sender, string receiverName);
    void AddUser(User user);
}

class Program
{
    static void Main(string[] args)
    {
        ChatMediator chatMediator = new ChatMediator();

        User user1 = new User("User1", chatMediator);
        User user2 = new User("User2", chatMediator);
        User user3 = new User("User3", chatMediator);

        chatMediator.AddUser(user1);
        chatMediator.AddUser(user2);
        chatMediator.AddUser(user3);

        user1.SendMessage("Привет, User2!", "User2");

        user1.SendMessage("как погода?", "User3");
        user2.SendMessage("как настроение?, User1", "User1");
        user3.SendMessage("как дела?", "User1");

        Console.WriteLine();
        user1.History();
        Console.WriteLine();
        user2.History();
        Console.WriteLine();
        user3.History();
        Console.WriteLine();

        chatMediator.RemoveUser(user2);
        chatMediator.RemoveUser(user3);
        chatMediator.RemoveUser(user1);
    }
}
