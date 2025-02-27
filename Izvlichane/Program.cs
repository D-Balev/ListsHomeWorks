namespace Izvlichane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи числа = ");
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int durjach = 0;
            if (numbers.Count == 1)
            {
                Console.WriteLine($"{numbers[0]}");
            }
            else
            {
                if (numbers.Count % 2 == 0)
                {
                    durjach = numbers.Count / 2;
                    Console.WriteLine($"Средните числа са = {numbers[durjach - 1]}, {numbers[durjach]}");
                }
                else
                {
                    durjach = numbers.Count / 2;
                    Console.WriteLine($"Средните числа са = {numbers[durjach - 1]}, {numbers[durjach]}, {numbers[durjach + 1]}");
                }
            }
        }
    }
}
