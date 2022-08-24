namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operation on Stack and Queue");
            Console.WriteLine("Press 1 to Push element into stack");
            Console.WriteLine("Press 2 for Peek and Pop from stack ");
            int input = int.Parse(Console.ReadLine());

            Stack stack = new Stack();
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
                default:
                    Console.WriteLine("Make proper selection");
                    break;
            }
        }
    }
}