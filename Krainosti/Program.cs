using System.Numerics;

namespace Krainosti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи числата = ");
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> mins = new List<int>();
            List<int> maxs = new List<int>();
            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == max)
                {
                    maxs.Add(numbers[i]);
                }
                if (numbers[i] == min)
                {
                    mins.Add(numbers[i]);
                }
            }
            for ( int i = 0;i < mins.Count; i++)
            {
                Console.Write($"{mins[i]}, ");
            }
            for ( int i = 0;i < maxs.Count; i++)
            {
                Console.Write($"{maxs[i]}, ");
            }
        }
    }
}
