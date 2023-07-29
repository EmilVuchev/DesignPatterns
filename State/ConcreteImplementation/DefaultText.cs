using State.Interfaces;

namespace State.ConcreteImplementation
{
    public class DefaultText : IWritingState
    {
        public void Write(string words)
        {
            Console.WriteLine(words);
        }
    }
}
