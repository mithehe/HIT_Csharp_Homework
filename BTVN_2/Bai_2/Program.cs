using System;

namespace BTVN_2
{
    public class Program
    {
        static int CalculateTotalDamage(int[] damages)
        {
            int total = 0;
            for(int i = 0; i < damages.Length; i++)
            {
                total += damages[i];
            }
            return total;
        }

        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine()); // so luong don tan cong
            int[] damages = new int[n];

            for(int i = 0; i < n; i++)
            {
                damages[i] = int.Parse(Console.ReadLine());
            }

            int hitDamage = 0, missDamage = 0, maxDamage = damages[0];
            for(int i = 0; i < n; i++){
                if (damages[i] > 0)
                {
                    hitDamage++;
                }
                else if(damages[i] < 0)
                {
                    missDamage++;
                }

                if (damages[i] > maxDamage)
                {
                    maxDamage = damages[i];
                }
            }

            Console.WriteLine($"Tong sat thuong: {CalculateTotalDamage(damages)}");
            Console.WriteLine($"So don danh trung: {hitDamage}");
            Console.WriteLine($"So don danh truot: {missDamage}");
            Console.WriteLine($"Sat thuong lon nhat: {maxDamage}");

        }
    }
}