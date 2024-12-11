namespace Mediator_Pattern
{
    public class User
    {
        public string Name { get; private set; }
        private readonly IChatMediator _chatMediator;
        private readonly List<string> _messageHistory;

        public User(string name, IChatMediator chatMediator)
        {
            Name = name;
            _chatMediator = chatMediator;
            _messageHistory = new List<string>();
        }

        public void SendMessage(string message, string login)
        {
            Console.WriteLine($"{Name} написал: {message}. Сообщение для {login}");
            _chatMediator.SendMessage(message, this, login);
        }

        public void ReceiveMessage(string message, string senderName)
        {
            Console.WriteLine($"{Name} получил сообщение от {senderName}: {message}");
            _messageHistory.Add($"От {senderName}: {message}");
        }

        public void History()
        {
            Console.WriteLine($"История сообщений для {Name}:");
            foreach (var message in _messageHistory) Console.WriteLine(message);

        }
    }
}
