using System;
using System.Runtime.InteropServices;

namespace BTVN_2
{
    public class Program
    {
        static int CalculateScore(int kills, int assists)
        {
            return kills * 100 + assists * 30;
        }

        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int maxScore = -1;
            string topPlayer = "";

            string[] players = new string[n];
            int[] score = new int[n];

            for (int i = 0; i < n; i++)
            {
                players[i] = Console.ReadLine();
                int skill = int.Parse(Console.ReadLine());
                int assist = int.Parse(Console.ReadLine());
                score[i] = CalculateScore(skill, assist);

                if (score[i] > maxScore)
                {
                    topPlayer = players[i];
                    maxScore = score[i];
                }
            }

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nguoi choi {i+1}: {players[i]} - {score[i]}");
            }

            Console.WriteLine($"Nguoi cao nhat: {topPlayer} \nDiem cao nhat: {maxScore}");

        }
            
   
    }
}