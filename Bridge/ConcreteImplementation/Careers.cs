using Bridge.Interfaces;

namespace Bridge.ConcreteImplementation
{
    public class Careers : IWebPage
    {
        private readonly ITheme theme;

        public Careers(ITheme theme)
        {
            this.theme = theme;
        }

        public string GetContent()
        {
            return $"Careers page in {this.theme.GetColor()}";
        }
    }
}
