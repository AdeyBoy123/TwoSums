using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSums
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
            if (indices != null)
            {
                Console.WriteLine($"Indices: {indices.Item1}, {indices.Item2}");
            }
            else
            {
                Console.WriteLine("No solution found!");
            }
        }

        public static Tuple<int, int> FindTwoSum(IList<int> list, int targetSum)
        {
            Dictionary<int, int> seenNumbers = new Dictionary<int, int>();

            for (int i = 0; i < list.Count; i++)
            {
                int numberNeeded = targetSum - list[i];
                if (seenNumbers.ContainsKey(numberNeeded))
                {
                    return new Tuple<int, int>(seenNumbers[numberNeeded], i);
                }
                if (!seenNumbers.ContainsKey(list[i]))
                {
                    seenNumbers[list[i]] = i;
                }
            }

            return null; // No solution found
        }
    }
}