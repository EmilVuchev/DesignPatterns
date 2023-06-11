namespace Memento.ConcreteImplementation
{
    public class EditorMemento
    {
        private readonly string content;

        public EditorMemento(string content)
        {
            this.content = content;
        }

        public string Content
        {
            get
            {
                return this.content;
            }
        }
    }
}
