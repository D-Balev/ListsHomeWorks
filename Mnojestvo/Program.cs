namespace Mnojestvo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Въведи k = "); 
            int k = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            numbers[0] = 1;
            for (int i = 1; i < n; i++)
            {
                int sum = 0;
                for (int j = i - k; j < i; j++)
                {
                    if (j >= 0)
                    {
                        sum += numbers[j];
                    }
                }
                numbers[i] = sum;
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
