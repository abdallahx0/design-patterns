using MementoPattern;

var editor = new TextEditor();
var caretaker = new Caretaker(editor);

caretaker.Type("Hello");
caretaker.Type(" World");
Console.WriteLine(editor.Text); // Output: Hello World

caretaker.Undo();
Console.WriteLine(editor.Text); // Output: Hello

caretaker.Redo();
Console.WriteLine(editor.Text); // Output: Hello World

caretaker.Type("!");
Console.WriteLine(editor.Text); // Output: Hello World!
