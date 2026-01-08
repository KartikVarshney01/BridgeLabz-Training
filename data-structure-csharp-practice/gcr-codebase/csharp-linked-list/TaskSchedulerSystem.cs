using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_linked_list
{
    internal class TaskSchedulerSystem
    {
        static void Main(String[] args)
        {
            TaskScheduler scheduler = new TaskScheduler();

            scheduler.AddAtBeginning(1, "Design", 1, DateTime.Now.AddDays(3));
            scheduler.AddAtEnd(2, "Code", 2, DateTime.Now.AddDays(2));
            scheduler.AddAtPosition(2, 3, "Testing", 1, DateTime.Now.AddDays(1));

            Console.WriteLine("All Tasks:");
            scheduler.DisplayAll();

            Console.WriteLine("Current Task:");
            scheduler.ViewCurrentAndMoveNext();

            Console.WriteLine("Next Task:");
            scheduler.ViewCurrentAndMoveNext();

            Console.WriteLine("Search by Priority 1:");
            scheduler.SearchByPriority(1);

            Console.WriteLine("Remove Task ID 2:");
            scheduler.RemoveByTaskId(2);

            Console.WriteLine("Final Task List:");
            scheduler.DisplayAll();
        }
    }

    // Task class (Node)
    class Task
    {
        public int TaskId;
        public string TaskName;
        public int Priority;
        public DateTime DueDate;
        public Task Next;

        public Task(int taskId, string taskName, int priority, DateTime dueDate)
        {
            TaskId = taskId;
            TaskName = taskName;
            Priority = priority;
            DueDate = dueDate;
            Next = null;
        }
    }

    // Circular Linked List
    class TaskScheduler
    {
        private Task head;
        private Task current;

        // Add at beginning
        public void AddAtBeginning(int id, string name, int priority, DateTime dueDate)
        {
            Task newTask = new Task(id, name, priority, dueDate);

            if (head == null)
            {
                head = current = newTask;
                newTask.Next = head;
                return;
            }

            Task temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }

            newTask.Next = head;
            temp.Next = newTask;
            head = newTask;
        }

        // Add at end
        public void AddAtEnd(int id, string name, int priority, DateTime dueDate)
        {
            Task newTask = new Task(id, name, priority, dueDate);

            if (head == null)
            {
                head = current = newTask;
                newTask.Next = head;
                return;
            }

            Task temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }

            temp.Next = newTask;
            newTask.Next = head;
        }

        // Add at specific position (1-based)
        public void AddAtPosition(int position, int id, string name, int priority, DateTime dueDate)
        {
            if (position <= 1)
            {
                AddAtBeginning(id, name, priority, dueDate);
                return;
            }

            Task temp = head;
            for (int i = 1; i < position - 1 && temp.Next != head; i++)
            {
                temp = temp.Next;
            }

            Task newTask = new Task(id, name, priority, dueDate);
            newTask.Next = temp.Next;
            temp.Next = newTask;
        }

        // Remove by Task ID
        public void RemoveByTaskId(int taskId)
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            Task temp = head;
            Task prev = null;

            do
            {
                if (temp.TaskId == taskId)
                {
                    if (prev != null)
                        prev.Next = temp.Next;

                    if (temp == head)
                    {
                        Task last = head;
                        while (last.Next != head)
                            last = last.Next;

                        head = temp.Next;
                        last.Next = head;
                    }

                    if (temp == current)
                        current = temp.Next;

                    Console.WriteLine("Task removed successfully.");
                    return;
                }

                prev = temp;
                temp = temp.Next;

            } while (temp != head);

            Console.WriteLine("Task not found.");
        }

        // View current task and move to next
        public void ViewCurrentAndMoveNext()
        {
            if (current == null)
            {
                Console.WriteLine("No tasks scheduled.");
                return;
            }

            DisplayTask(current);
            current = current.Next;
        }

        // Display all tasks
        public void DisplayAll()
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            Task temp = head;
            do
            {
                DisplayTask(temp);
                temp = temp.Next;
            } while (temp != head);
        }

        // Search by Priority
        public void SearchByPriority(int priority)
        {
            if (head == null)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            Task temp = head;
            bool found = false;

            do
            {
                if (temp.Priority == priority)
                {
                    DisplayTask(temp);
                    found = true;
                }
                temp = temp.Next;
            } while (temp != head);

            if (!found)
                Console.WriteLine("No task found with this priority.");
        }

        // Display method
        private void DisplayTask(Task task)
        {
            Console.WriteLine(
                $"ID: {task.TaskId}, Name: {task.TaskName}, Priority: {task.Priority}, Due: {task.DueDate.ToShortDateString()}"
            );
        }
    }

}
