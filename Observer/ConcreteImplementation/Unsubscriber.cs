namespace Observer.ConcreteImplementation
{
    public class Unsubscriber<JobPost> : IDisposable
    {
        private List<IObserver<JobPost>> observers;
        private IObserver<JobPost> observer;

        internal Unsubscriber(List<IObserver<JobPost>> observers, IObserver<JobPost> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }

        public void Dispose()
        {
            if (this.observers.Contains(this.observer))
                this.observers.Remove(this.observer);
        }
    }
}
