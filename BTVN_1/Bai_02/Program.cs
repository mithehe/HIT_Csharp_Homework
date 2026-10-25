using System;
using System.Globalization;

namespace BTVN_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name;
            int HP;
            float tocDo;
            char hang;

            Console.Write("Ten nhan vat: ");
            name = Console.ReadLine();

            Console.Write("HP: ");
            while (!int.TryParse(Console.ReadLine(), out HP) || HP < 0 || HP > 1000)
            {
                Console.Write("Nhap lai HP: ");
            }

            Console.Write("Toc do: ");
            tocDo = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //su dung CultureInfo.InvariantCulture de doc so thap phan voi dau cham thay vi dau phay
            Console.Write("Hang: ");
            hang = char.Parse(Console.ReadLine());

            bool isAlive = false;
            if(HP > 0)
            {
                isAlive = true;
            }
            else
            {
                isAlive = false;
            }

            //In thong tin nhan vat
            Console.WriteLine("=================Thong tin nhan vat===============");
            Console.WriteLine("Ten: " + name);
            Console.WriteLine("HP: " + HP);
            Console.WriteLine("Toc do: " + tocDo); 
            Console.WriteLine("Hang: " + hang);
            Console.WriteLine("Con song: " + isAlive);

        }
    }
}