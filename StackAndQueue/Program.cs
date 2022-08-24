namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operation on Stack and Queue");
            Console.WriteLine("Press 1 to Push element into stack");
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
                default:
                    Console.WriteLine("Make proper selection");
                    break;
            }
        }
    }
}