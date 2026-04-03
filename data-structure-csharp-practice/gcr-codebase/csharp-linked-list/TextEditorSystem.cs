using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_linked_list
{
    internal class TextEditorSystem
    {
        static void Main(String[] args)
        {
            TextEditor editor = new TextEditor(5);

            editor.AddState("Hello");
            editor.AddState("Hello World");
            editor.AddState("Hello World!");
            editor.DisplayCurrent();

            editor.Undo();
            editor.DisplayCurrent();
            editor.Redo();
            editor.DisplayCurrent();

            editor.AddState("Hello World!!");
            editor.DisplayCurrent();
        }
    }

    class TextState
    {
        public string Content;
        public TextState Prev;
        public TextState Next;

        public TextState(string content)
        {
            Content = content;
            Prev = null;
            Next = null;
        }
    }

    class TextEditor
    {
        private TextState head;
        private TextState current;
        private int maxHistory;

        public TextEditor(int historyLimit = 10)
        {
            head = current = null;
            maxHistory = historyLimit;
        }

        // Add a new text state
        public void AddState(string content)
        {
            TextState newState = new TextState(content);

            if (current == null)
            {
                head = current = newState;
            }
            else
            {
                current.Next = newState;
                newState.Prev = current;
                current = newState;

                // Limit history size
                TextState temp = current;
                int count = 1;
                while (temp.Prev != null)
                {
                    count++;
                    temp = temp.Prev;
                }
                if (count > maxHistory)
                {
                    head = head.Next;
                    head.Prev = null;
                }
            }
        }

        // Undo
        public void Undo()
        {
            if (current != null && current.Prev != null)
            {
                current = current.Prev;
                Console.WriteLine($"Undo: {current.Content}");
            }
            else
                Console.WriteLine("Cannot undo further.");
        }

        // Redo
        public void Redo()
        {
            if (current != null && current.Next != null)
            {
                current = current.Next;
                Console.WriteLine($"Redo: {current.Content}");
            }
            else
                Console.WriteLine("Cannot redo further.");
        }

        // Display current content
        public void DisplayCurrent()
        {
            if (current != null)
                Console.WriteLine($"Current Content: {current.Content}");
            else
                Console.WriteLine("No content.");
        }
    }
}
