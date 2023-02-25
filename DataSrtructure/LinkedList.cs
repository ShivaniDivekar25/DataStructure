using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSrtructure
{
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if(this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} is inserted into linked list.",node.data);
        }
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
            Console.WriteLine("{0} is added into linked list",newNode.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            Console.WriteLine("Linked list is: ");
            while(temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        public void Append(int data)
        {
            Node newNode = new Node(data);
            if(head == null)
            {
                head = newNode;
                Console.WriteLine("{0} is added into linked list", newNode.data);
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                Console.WriteLine("{0} is added into linked list", newNode.data);
            }
        }
        public void Display1()
        {
            Console.WriteLine("\nDisplaying all nodes");
            if(head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                Node temp = head;
                while(temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
        public void RemoveFirstNode()
        {
            if(head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            this.head = this.head.next;
            Console.WriteLine("First element is deleted successfully");
        }
        public void RemoveAtLast()
        {
            if(head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            if(head.next == null)
            {
                head = null;
            }
            else
            {
                Node lastNode = this.head;
                while(lastNode.next.next != null)
                {
                    lastNode = lastNode.next;
                }
                lastNode.next = null;
                Console.WriteLine("The last node is deleted successfully");
            }
        }
        public void InsertNode(int data, int afterNum)
        {
            Node node = new Node(data);
            Node temp = head;
            while(temp.data != afterNum)
            {
                temp = temp.next;
            }
            node.next = temp.next;
            temp.next = node;
            Console.WriteLine("Node {0} inserted after {1}.",data,afterNum);
        }
        public void Search(int input)
        {
            bool isFound = false;
            if(head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                Node temp = head;
                while(temp != null)
                {
                    if(temp != null)
                    {
                        isFound = true;
                        Console.WriteLine("Given node {0} is present.",input);
                        break;
                    }
                    temp = temp.next;
                }
                if(!isFound)
                    Console.WriteLine("Given node {0} is not present", input);
            }
        }
    }
}
