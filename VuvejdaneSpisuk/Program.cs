namespace VuvejdaneSpisuk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи числа = ");
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"number[{i}] = {numbers[i]}");
            }
        }
    }
}
