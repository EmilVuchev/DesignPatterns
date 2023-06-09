namespace Flyweight.ConcreteImplementation
{
    public class TeaMaker
    {
        private readonly Dictionary<string, KarakTea> availableTea;

        public TeaMaker()
        {
            this.availableTea = new Dictionary<string, KarakTea>();
        }

        public KarakTea Make(string preference) 
        {
            if (!this.availableTea.ContainsKey(preference))
            {
                availableTea[preference] = new KarakTea();
            }

            return availableTea[preference];
        }
    }
}
