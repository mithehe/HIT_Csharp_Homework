using System;

namespace BTVN_2
{
    public class Program
    {
        static int CalculateDamage(int attack, int armor)
        {
            if (attack - armor < 0) return 0;
            return attack - armor;
        }

        static int CalculateRemainingHp(int currentHp, int damage)
        {
            if (currentHp - damage < 0) return 0;
            return currentHp - damage;
        }

        static void Main(string[] args)
        {
            int initialHp = int.Parse(Console.ReadLine()); //luong mau ban dau
            int armor = int.Parse(Console.ReadLine()); // luong giap co dinh
            int n = int.Parse(Console.ReadLine()); // so luong don tan cong

            //danh sach cac don danh
            int[] attacks = new int[n];
            for(int i = 0; i < n; i++)
            {
                attacks[i] = int.Parse(Console.ReadLine());
            }
            
            int currentHp = initialHp;
            int processedAttacks = 0, fatalHit = -1;

            for(int i = 0; i < n; i++){
                int damage = CalculateDamage(attacks[i], armor);
                currentHp = CalculateRemainingHp(currentHp, damage);
                processedAttacks++;

                Console.WriteLine($"Don {i + 1}: Sat thuong {damage} | HP {currentHp}");

                if(currentHp == 0 && fatalHit == -1)
                {
                    fatalHit = i + 1;
                    break;
                }
            }

            int totalLostHp = initialHp - currentHp;

            if (currentHp == 0)
            {
                Console.WriteLine("Trang thai: Da bi ha");
                Console.WriteLine($"So don da xu ly: {processedAttacks}");
                Console.WriteLine($"Tong HP da mat: {totalLostHp}");
                Console.WriteLine($"Don ket lieu: {fatalHit}");
            }
            else
            {
                Console.WriteLine("Trang thai: Song sot");
                Console.WriteLine($"So don da xu ly: {processedAttacks}");
                Console.WriteLine($"Tong HP da mat: {totalLostHp}");
            }

        }
    }
}