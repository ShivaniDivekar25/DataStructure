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
    }
}
