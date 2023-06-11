using Command.Interfaces;

namespace Command.ConcreteImplementation
{
    public class TurnOff : ICommand
    {
        private readonly Bulb bulb;

        public TurnOff(Bulb bulb)
        {
            this.bulb = bulb;
        }

        public void Execute()
        {
            this.bulb.TurnOff();
        }

        public void Redo()
        {
            Execute();
        }

        public void Undo()
        {
            this.bulb.TurnOn();
        }
    }
}
