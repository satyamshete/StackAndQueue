using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackAndQueue
{
    internal class Stack
    {
        public Node TOP;
       

        public Stack()
        {
            TOP = null;
          
        }
        public void Push(int data)
        {
            Node node = new Node(data);
            node.Next = TOP;
            TOP = node;
           

        }
        public void Display()
        {
            if (this.TOP == null)
            {
                Console.WriteLine("No elements present ");
            }
            else
            {
                Console.WriteLine("Elements present are: ");
                Node temp = TOP;

                while (temp != null)
                {
                    Console.WriteLine(temp.Data + " ");
                    temp = temp.Next;

                }


            }
            Console.WriteLine();
        }
        public void Peak()
        {
            Console.WriteLine("Top Element is: " + TOP.Data);
        }
        public void Pop()
        {
            if (this.TOP == null)
            {
                Console.WriteLine("No elements present ");
            }
            else
            {
                TOP = TOP.Next;
                Console.WriteLine("Deleted the top element");
            }
            Display();
            Console.WriteLine();
        }
    }
}
