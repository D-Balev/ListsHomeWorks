namespace Maksimalen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи числата = ");
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int start = numbers[0];
            int bestlength = 1;
            int length = 1;
            int beststart = 0;
            int naidoburstart = 0;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    length++;
                }
                else
                {
                    if (length > bestlength)
                    {
                        bestlength = length;
                        beststart = naidoburstart;
                    }
                    length = 1;
                    naidoburstart = i;
                }
            }
            if (length > bestlength)
            {
                bestlength = length;
                beststart = naidoburstart;
            }
            for (int i = beststart;i < beststart + bestlength;i++)
            {
                Console.Write($"{numbers[i]}, ");
            }
        }
    }
}
