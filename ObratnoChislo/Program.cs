using System.Globalization;

namespace ObratnoChislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //da sutvorim obratnoto chislo
            Console.Write("Дай число = ");
            List<int> number = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < number.Count; i++)
            {
                int num = number[i];
                int reversed = 0;
            }
        }
    }
}


