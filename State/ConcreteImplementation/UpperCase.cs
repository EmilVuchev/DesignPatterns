using State.Interfaces;

namespace State.ConcreteImplementation
{
    public class UpperCase : IWritingState
    {
        public void Write(string words)
        {
            Console.WriteLine(words.ToUpper());
        }
    }
}
