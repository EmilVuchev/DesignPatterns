using Bridge.Interfaces;

namespace Bridge.ConcreteImplementation
{
    public class About : IWebPage
    {
        private readonly ITheme theme;

        public About(ITheme theme)
        {
            this.theme = theme;
        }

        public string GetContent()
        {
            return $"About page in {theme.GetColor()}";
        }
    }
}
