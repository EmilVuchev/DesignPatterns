using Command.Interfaces;

namespace Command.ConcreteImplementation
{
    public class RemoteControl
    {
        public void Submit(ICommand command)
        {
            command.Execute();
        }

        public void Undo(ICommand command)
        {
            command.Undo();
        }

        public void Redo(ICommand command) 
        {
            command.Redo();
        }
    }
}
