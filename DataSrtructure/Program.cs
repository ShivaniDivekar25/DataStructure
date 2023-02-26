using DataStructure;

namespace DataSrtructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to data structure programs");
            LinkedList linkedList = new LinkedList();
            Stack stack = new Stack();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Please enter an option");
                Console.WriteLine("1:Create linked list\n2:Create linked list by adding\n3:Create linked list by Append\n4:Remove first element in linked list\n5:Remove last element in linked list\n6:Insert node in linked list\n7:Search node in linked list\n8:Insert after given node linked list\n9:Remove at given position\n10:Create stack using Linked list\n11:Create Peak and Pop method");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        break;
                    case 2:
                        linkedList.AddFirst(70);
                        linkedList.AddFirst(30);
                        linkedList.AddFirst(56);
                        linkedList.Display();
                        break;
                    case 3:
                        linkedList.Append(56);
                        linkedList.Append(30);
                        linkedList.Append(70);
                        linkedList.Display1();
                        break;
                    case 4:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveFirstNode();
                        linkedList.Display();
                        break;
                    case 5:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveAtLast();
                        linkedList.Display();
                        break;
                    case 6:
                        linkedList.Add(56);
                        linkedList.Add(70);
                        linkedList.InsertNode(30, 56);
                        linkedList.Display();
                        break;
                    case 7:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Search(30);
                        break;
                    case 8:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.InsertNode(40, 30);
                        linkedList.Add(70);
                        linkedList.Display();
                        break;
                    case 9:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(40);
                        linkedList.Add(70);
                        linkedList.RemoveAtGivenPosition();   
                        linkedList.Display();
                        linkedList.Size();
                        break;
                    case 10:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        stack.Display();
                        break;
                    case 11:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        stack.Display();
                        stack.IsEmpty();
                        break;
                    case 12:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Please enter right option");
                        break;
                }
            }
        }
    }
}