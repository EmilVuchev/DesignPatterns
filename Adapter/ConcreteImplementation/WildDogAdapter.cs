using Adapter.Interfaces;

namespace Adapter.ConcreteImplementation
{
    public class WildDogAdapter : ILion
    {
        private readonly WildDog wildDog;

        public WildDogAdapter(WildDog wildDog)
        {
            this.wildDog = wildDog;
        }

        public void Roar()
        {
            this.wildDog.Bark();
        }
    }
}
