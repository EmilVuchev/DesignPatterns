using Command.Interfaces;

namespace Command.ConcreteImplementation
{
    internal class TurnOn : ICommand
    {
        private readonly Bulb bulb;

        public TurnOn(Bulb bulb)
        {
            this.bulb = bulb;
        }

        public void Execute()
        {
            this.bulb.TurnOn();
        }

        public void Redo()
        {
            Execute();
        }

        public void Undo()
        {
            this.bulb.TurnOff();
        }
    }
}
