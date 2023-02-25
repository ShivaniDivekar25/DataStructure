namespace DataSrtructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to data structure programs");
            LinkedList linkedList = new LinkedList();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Please enter an option");
                Console.WriteLine("1:Create linked list\n2:Create linked list by adding\n3:Create linked list by Append\n4:Remove first element in linked list\n5:Remove last element in linked list\n6:Insert node in linked list");
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