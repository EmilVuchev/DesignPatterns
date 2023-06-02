using FactoryMethod.Interfaces;

namespace FactoryMethod.AbstractClasses
{
    public abstract class HiringManager
    {
        protected abstract IInterviewer MakeInterviewer();

        public void TakeInterview() 
        {
            var interviewer = this.MakeInterviewer();
            interviewer.AskQuestions();
        }
    }
}
