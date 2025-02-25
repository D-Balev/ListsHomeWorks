namespace ListInputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи брой = ");
            int n = int.Parse(Console.ReadLine());
            List <int> numbers = new List<int>();
            for ( int i =0; i < n; i++ )
            {
                Console.Write("Въведи число = ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            for ( int i = 0; i < numbers.Count; i++ )
            {
                Console.WriteLine($"list[{i}] = {numbers[i]}");
            }
        }
    }
}
