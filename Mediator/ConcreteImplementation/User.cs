using Mediator.Interfaces;

namespace Mediator.ConcreteImplementation
{
    public class User
    {
        private readonly string name;
        private readonly IChatRoomMediator chatRoom;

        public User(string name, IChatRoomMediator chatRoom)
        {
            this.name = name;
            this.chatRoom = chatRoom;
        }

        public string GetName()
        {
            return this.name;
        }

        public void Send(string message)
        {
            this.chatRoom.ShowMessage(this, message);
        }
    }
}
