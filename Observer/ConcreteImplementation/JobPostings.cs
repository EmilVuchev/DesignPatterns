using System;

namespace Observer.ConcreteImplementation
{
    public class JobPostings : IObservable<JobPost>
    {
        private List<IObserver<JobPost>> observers;
        private List<JobPost> jobPostings;

        public JobPostings()
        {
            this.observers = new List<IObserver<JobPost>>();
            this.jobPostings = new List<JobPost>();
        }

        public IDisposable Subscribe(IObserver<JobPost> observer)
        {
            if (!this.observers.Contains(observer))
            {
                this.observers.Add(observer);
            }

            return new Unsubscriber<JobPost>(this.observers, observer);
        }

        private void Notify(JobPost jobPost)
        {
            foreach (var observer in this.observers)
            {
                observer.OnNext(jobPost);
            }
        }

        public void AddJob(JobPost jobPost)
        {
            this.jobPostings.Add(jobPost);
            Notify(jobPost);
        }
    }
}
