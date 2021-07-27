using System;
using System.Linq;
using System.Numerics;

namespace GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        
        static int GreatestCommonDiv(int a, int b)
        {
            if (b == 0)
                return a;
            return GreatestCommonDiv(b, a % b);
            
        }
        
        
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var numbers = input.Split(' ').Select(int.Parse).ToArray();

            var a = numbers[0];
            var b = numbers[1];            
            Console.Write(GreatestCommonDiv(a, b));           
        }
    }
}
