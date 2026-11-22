using System;

namespace BTVN_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> users = new Queue<string>();
            Stack<string> history = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string user = Console.ReadLine();
                users.Enqueue(user);
            }

            while(users.Count > 0)
            {
                string name = users.Dequeue();
                Console.WriteLine($"Phuc vu: {name}");
                history.Push(name);
            }

            if(history.Count == 0)
            {
                Console.WriteLine("Chua phuc vu ai");
            }
            else
            {
                Console.WriteLine($"Gan nhat: {history.Peek()}"); 
                
            }
        }
    }
}