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
                Console.WriteLine("1:Create linked list");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        break;
                    default:
                        Console.WriteLine("Please enter right option");
                        break;
                }
            }
        }
    }
}