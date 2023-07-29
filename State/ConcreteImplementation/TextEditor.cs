using State.Interfaces;

namespace State.ConcreteImplementation
{
    public class TextEditor
    {
        private IWritingState state;

        public TextEditor()
        {
            this.state = new DefaultText();
        }

        public void SetState(IWritingState state)
        {
            this.state = state;
        }

        public void Type(string words)
        {
            this.state.Write(words);
        }
    }
}
