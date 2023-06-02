using FactoryMethod.Interfaces;

namespace FactoryMethod.ConcreteImplementation
{
    public class CommunityExecutive : IInterviewer
    {
        public void AskQuestions()
        {
            Console.WriteLine("Asking about community building!");
        }
    }
}
