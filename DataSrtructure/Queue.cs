using DataSrtructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Queue
    {
        public Node head;
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if(this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("{0} is inserted into queue",newNode.data);
        }
        public void Display()
        {
            Node temp = this.head;
            while(temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        public void Dequeue()
        {
            if(head == null)
            {
                Console.WriteLine("No nodes are present in queue");
            }
            else
            {
                head = head.next;
            }
        }
    }
}
