﻿using Memento.ConcreteImplementation;

var editor = new Editor();

editor.Type("This is the first sentence.");
editor.Type("This is second.");

editor.Save();

Console.WriteLine(editor.Content);

editor.Type("This is third.");

Console.WriteLine(editor.Content);

editor.Restore();

Console.Write(editor.Content);