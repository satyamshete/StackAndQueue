using System.Collections.Generic;

namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operation on Stack and Queue");
            Console.WriteLine("Press 1 to Push element into stack");
            Console.WriteLine("Press 2 for Peek and Pop from stack ");
            Console.WriteLine("Press 3 for Append into Queue ");
            Console.WriteLine("Press 4 for deque elements from Queue ");
            int input = int.Parse(Console.ReadLine());

            Stack stack = new Stack();
            Queue queue = new Queue();
            switch (input)
            {
                case 1:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    break;
                case 2:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    stack.Peak();
                    stack.Pop();
                    stack.Peak();
                    stack.Pop();
                    stack.Peak();
                    stack.Pop();
                    break;
                case 3:
                    queue.Append(56);
                    queue.Append(30);
                    queue.Append(70);
                    queue.Display();
                    break;
                case 4:
                    queue.Append(56);
                    queue.Append(30);
                    queue.Append(70);
                    queue.Display();
                    queue.Deque();
                    queue.Display();
                    queue.Deque();
                    queue.Display();
                    queue.Deque();
                    queue.Display();
                    break;
                default:
                    Console.WriteLine("Make proper selection");
                    break;
            }
        }
    }
}