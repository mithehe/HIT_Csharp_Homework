using System;
namespace BTVN_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> achiCodes = new HashSet<string>();

            for(int i = 0; i < n; i++)
            {
                string code = Console.ReadLine();
                achiCodes.Add(code);
            }
            Console.WriteLine($"Thanh tuu duy nhat: {achiCodes.Count}");

            string checkCode = Console.ReadLine();
            Console.WriteLine($"Da mo khoa {checkCode}: {achiCodes.Contains(checkCode)}");

            
        }
    }
}
          