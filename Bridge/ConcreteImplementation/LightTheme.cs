using Bridge.Interfaces;

namespace Bridge.ConcreteImplementation
{
    public class LightTheme : ITheme
    {
        public string GetColor()
        {
            return "Off Light";
        }
    }
}
