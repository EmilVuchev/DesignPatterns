namespace Iterator.ConcreteImplementation
{
    public class RadioStation
    {
        private readonly double frequency;

        public RadioStation(double frequency)
        {
            this.frequency = frequency;
        }

        public double GetFrequency() 
        {
            return this.frequency;
        }
    }
}
