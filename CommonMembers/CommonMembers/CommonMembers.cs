using System;
using System.Collections.Generic;
using System.Linq;

namespace CommonMembers
{
    class CommonMembers
    {
        static void Main(string[] args)
        {
            List<int> sequence1 = new List<int>();
            List<int> sequence2 = new List<int>();
            var input = Console.ReadLine();
            var numbers = input.Split(' ').Select(x => int.Parse(x)).ToArray();
            var q = numbers[0];
            var quantity = q;
            var lastIndex = quantity + 1;

            for (int i = 0; i < lastIndex; i++)
            {
                sequence1.Add(numbers[i]);
            }

            for (int i = lastIndex; i < numbers.Length; i++)
            {
                sequence2.Add(numbers[i]);
            }

            //var a = sequence1.SequenceEqual(sequence2);

            int quantity2 = numbers[lastIndex];
            if (numbers.Count() - 2 == quantity + quantity2)
            {
                sequence1.RemoveAt(0);
                sequence2.RemoveAt(0);

                List<int> duplicates = sequence1.Intersect(sequence2).ToList();                

                string output = string.Join(" ", duplicates);
               Console.Write("{0} {1}", duplicates.Count(), output);                
            }
        }
    }
}


//var input = Console.ReadLine();
//var numbers = input.Split(' ').Select(int.Parse).ToList();
//var quantity = numbers[0];
//var quantity2 = numbers[quantity + 1];
//numbers.RemoveAt(numbers[quantity + 1]);
//numbers.RemoveAt(0);

//if (quantity == 0 || quantity2 == 0)
//{
//    Console.Write(0);
//}
//else
//{
//    if (numbers.Count == (quantity + quantity2))
//    {
//        var query = numbers.GroupBy(x => x)
//        .Where(g => g.Count() > 1)
//        .Select(y => y.Key)
//        .ToList();


//        string output = string.Join(" ", query);
//        Console.Write("{0} {1}", output.Count(), output);
//    }
//    else
//    {
//        Console.Write(-1);
//    }
//}
