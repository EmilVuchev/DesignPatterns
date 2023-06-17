namespace Observer.ConcreteImplementation
{
    public class JobSeeker : IObserver<JobPost>
    {
        public JobSeeker(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        //Method is not being called by JobPostings class currently
        public void OnCompleted()
        {
            //No Implementation
        }

        //Method is not being called by JobPostings class currently
        public void OnError(Exception error)
        {
            //No Implementation
        }

        public void OnNext(JobPost value)
        {
            Console.WriteLine($"Hi {this.Name} ! New job posted: {value.Title}");
        }

        public IDisposable Subscribe(IObserver<JobPost> observer)
        {
            throw new NotImplementedException();
        }
    }
}
