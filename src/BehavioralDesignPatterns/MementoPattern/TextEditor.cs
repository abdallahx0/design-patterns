namespace MementoPattern
{
    internal class TextEditor
    {
        public string Text { get; private set; } = string.Empty;

        public void Type(string words)
        {
            Text += words;
        }

        public Memento Save()
        {
            return new Memento(Text);
        }

        public void Restore(Memento memento)
        {
            Text = memento.State;
        }
    }
}
