using System;
namespace BTVN_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> bags = new List<string>();
            Dictionary<string, int> count = new Dictionary<string, int>();

            for(int i = 0; i < n; i++)
            {
                string item = Console.ReadLine();
                bags.Add(item);

                if(count.TryGetValue(item, out int c))
                {
                    count[item] = c + 1;
                }
                else
                {
                    count[item] = 1;
                }
            }

            Console.WriteLine("Da nhat: " + n);

            string ma_tra_cuu = Console.ReadLine();
            string ma_can_bo = Console.ReadLine();

            count.TryGetValue(ma_tra_cuu, out int so_luong);
            Console.WriteLine("So luong: " + so_luong);

            int idx = bags.IndexOf(ma_can_bo);
            if (idx < 0)
            {
                Console.WriteLine("Khong co vat pham");
            }
            else
            {
                bags.RemoveAt(idx);
                count[ma_can_bo]--;
                if (count[ma_can_bo] == 0)
                    count.Remove(ma_can_bo);
            }

            if (bags.Count == 0)
                Console.WriteLine("Con lai: (rong)");
            else
                Console.WriteLine("Con lai: " + string.Join(" ", bags));
        }
    }
}