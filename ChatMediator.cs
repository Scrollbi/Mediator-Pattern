namespace Mediator_Pattern
{
    public class ChatMediator : IChatMediator
    {
        private readonly List<User> _users;

        public ChatMediator()
        {
            _users = new List<User>();
        }

        public void SendMessage(string message, User sender, string receiverName)
        {
            User receiver = _users.Find(u => u.Name == receiverName);
            receiver.ReceiveMessage(message, sender.Name);
            
        }

        public void AddUser(User user)
        {
            _users.Add(user);
            Console.WriteLine($"{user.Name} вошел в чат.");
        }

        public void RemoveUser(User user)
        {
            _users.Remove(user);
            Console.WriteLine($"{user.Name} вышел из чата.");
        }
    }
}
