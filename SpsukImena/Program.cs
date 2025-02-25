namespace SpsukImena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи имена = ");
            List<string> names = Console.ReadLine().Split(' ').ToList();
            for ( int i = names.Count-1; i >= 0; i-- )
            {
                Console.Write($"{names[i]}; ");
            }
        }
    }
}
