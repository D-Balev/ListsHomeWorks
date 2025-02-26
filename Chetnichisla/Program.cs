namespace Chetnichisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи числата = ");
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> zapa = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    zapa.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(", " ,zapa));
        }
    }
}
