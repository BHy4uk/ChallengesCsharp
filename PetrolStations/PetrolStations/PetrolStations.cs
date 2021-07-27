using System;
using System.Linq;

namespace PetrolStations
{
    class PetrolStations
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var numbers = input.Split(' ').Select(int.Parse).ToList();
            var c_A = numbers[0];
            var c_B = numbers[1];
            var citiesDist = c_B - c_A;
            var k = numbers[2];
            var tank = k;
            var tankQuantity = numbers[3];
            numbers.RemoveRange(0, 4);
            var s_i = numbers;
            s_i.Sort();

            int count = 0;
            int dist;

            for (int i = 0; i < s_i.Count; i++)
            {
                if (i == 0) dist = s_i[i] - c_A;
                else if (i == s_i.Count - 1) dist = citiesDist - s_i[i];
                else dist = s_i[i + 1] - s_i[i];

                if (dist > k)
                {
                    Console.Write(-1);
                    break;
                }

                tank -= dist;
                if (tank == 0)
                {
                    count++;
                    tank = k;
                }
                else if (tank < 0)
                {
                    count++;
                    tank = k;
                }
                if (i == s_i.Count - 1)
                    Console.Write(count);
            }

        }
    }
}

