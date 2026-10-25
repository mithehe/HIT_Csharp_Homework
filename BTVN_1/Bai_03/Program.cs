using System;
namespace BTVN_01
{
    public class Program
    {
        const int PointsPerEnemy = 150;
        public static void Main(string[] args)
        {
            int enemyCount, totalSeconds;
            //Nhập số địch trong đoạn [0,10000]
            Console.Write("So dich da ha: ");
            while(!int.TryParse(Console.ReadLine(), out enemyCount) || enemyCount < 0 || enemyCount > 10000)
            {
                Console.Write("Nhap lai so dich da ha: ");
            }
            //Nhập thời gian chơi trong đoạn [1,86400]
            Console.Write("Tong thoi gian da choi: ");
            while (!int.TryParse(Console.ReadLine(), out totalSeconds) || totalSeconds < 1 || totalSeconds > 86400)
            {
                Console.Write("Nhap lai tong thoi gian da choi: ");
            }

            int point = enemyCount * PointsPerEnemy;
            float averagePointsPerSecond = (float)(enemyCount * 60.0f)/ totalSeconds;
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;
            Console.Write($"Tong diem: {point}\nThoi gian: {minutes} phút {seconds} giây\nDich/phut: {averagePointsPerSecond:F2}");
        }
    }
}