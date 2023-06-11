namespace Memento.ConcreteImplementation
{
    public class Editor
    {
        private EditorMemento memento;
        private string content;

        public Editor()
        {
            this.memento = new EditorMemento(string.Empty);
        }

        public void Type(string words)
        {
            this.content = String.Concat(this.content, " ", words);
        }

        public string Content
        {
            get
            {
                return this.content;
            }
        }

        public void Save()
        {
            this.memento = new EditorMemento(this.content);
        }

        public void Restore()
        {
            this.content = this.memento.Content;
        }
    }
}