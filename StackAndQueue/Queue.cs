using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class Queue
    {
        public Node Head;
        public Node Tail;
        public void Append(int Data) 
        {
            Node node = new Node(Data);
            if (this.Head == null)
            {
                this.Head = node;
                this.Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
            Console.WriteLine("{0} is Added ", Data);
        }
        public void Display()
        {
            if (this.Head == null)
            {
                Console.WriteLine("No elements present ");
            }
            else
            {
                Console.WriteLine("Elements present in queue are: ");
                Node temp = Head;

                while (temp != null)
                {
                    Console.Write(temp.Data + " ");
                    temp = temp.Next;

                }


            }
            Console.WriteLine();
        }
        public void Deque()
        {
            if (this.Head == null)
            {
                Console.WriteLine("No elements present ");
            }
            else
            {
                Head = Head.Next;
                Console.WriteLine("Deleted the first element");
            }

        }
    }
}
