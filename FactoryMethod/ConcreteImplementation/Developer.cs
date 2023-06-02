using FactoryMethod.Interfaces;

namespace FactoryMethod.ConcreteImplementation
{
    public class Developer : IInterviewer
    {
        public void AskQuestions()
        {
            Console.WriteLine("Asking about design patterns!");
        }
    }
}
