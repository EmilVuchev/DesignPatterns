namespace Facade.ConcreteImplementation
{
    public class ComputerFacade
    {
        private readonly Computer computer;

        public ComputerFacade(Computer computer)
        {
            this.computer = computer ?? throw new ArgumentNullException("computer", "Computer should not be null");
        }

        public void TurnOn() 
        {
            this.computer.GetElectricShock();
            this.computer.MakeSound();
            this.computer.ShowLoadingScreen();
            this.computer.Bam();
        }

        public void TurnOff() 
        {
            this.computer.CloseEverything();
            this.computer.PullCurrent();
            this.computer.Sooth();
        }
    }
}
