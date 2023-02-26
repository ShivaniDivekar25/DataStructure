using DataSrtructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Stack
    {
        public Node top;
        public void Push(int data)
        {
            Node node = new Node(data);
            if(this.top != null)
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("New node {0} pushed to stack",data);
        }
        public void Display()
        {
            Node temp = this.top;
            while(temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        public void Peek()
        {
            if(this.top == null)
            {
                Console.WriteLine("No element present in the stack");
                return;
            }
            Console.WriteLine("\nTop most element " + this.top.data);
        }
        public void Pop()
        {
            if(this.top == null)
            {
                Console.WriteLine("Stack is empty, deleting is not possible");
                return;
            }
            Console.WriteLine("value popped is {0}",this.top.data);
            this.top = this.top.next;
        }
        public void IsEmpty()
        {
            while(this.top != null)
            {
                Peek();
                Pop();
            }
            Console.WriteLine("The stack is empty");
        }
    }
}
