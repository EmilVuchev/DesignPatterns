using Mediator.ConcreteImplementation;

namespace Mediator.Interfaces
{
    public interface IChatRoomMediator
    {
        void ShowMessage(User user, string message);
    }
}
