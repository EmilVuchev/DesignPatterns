using State.Interfaces;

namespace State.ConcreteImplementation
{
    public class LowerCase : IWritingState
    {
        public void Write(string words)
        {
            Console.WriteLine(words.ToLower());
        }
    }
}
