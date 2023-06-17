namespace Observer.ConcreteImplementation
{
    public class JobPost
    {
        public string Title { get; private set; }

        public JobPost(string title)
        {
            this.Title = title;
        }
    }
}
