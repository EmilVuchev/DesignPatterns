using Bridge.Interfaces;

namespace Bridge.ConcreteImplementation
{
    public class DarkTheme : ITheme
    {
        public string GetColor()
        {
            return "Dark Black";
        }
    }
}
