namespace MementoPattern
{
    internal class Caretaker
    {
        private readonly TextEditor _editor;
        private readonly Stack<Memento> _undoStack = new Stack<Memento>();
        private readonly Stack<Memento> _redoStack = new Stack<Memento>();

        public Caretaker(TextEditor editor)
        {
            _editor = editor;
        }

        public void Type(string words)
        {
            _undoStack.Push(_editor.Save());
            _redoStack.Clear();
            _editor.Type(words);
        }

        public void Undo()
        {
            if (_undoStack.Count > 0)
            {
                _redoStack.Push(_editor.Save());
                _editor.Restore(_undoStack.Pop());
            }
        }

        public void Redo()
        {
            if (_redoStack.Count > 0)
            {
                _undoStack.Push(_editor.Save());
                _editor.Restore(_redoStack.Pop());
            }
        }
    }
}
