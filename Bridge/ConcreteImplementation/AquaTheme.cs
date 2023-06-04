using Bridge.Interfaces;

namespace Bridge.ConcreteImplementation
{
    public class AquaTheme : ITheme
    {
        public string GetColor()
        {
            return "Light Blue";
        }
    }
}
