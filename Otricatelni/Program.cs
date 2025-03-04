namespace Otricatelni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи числа = ");
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for ( int i = nums.Count-1; i >= 0; i-- )
            {
                if (0 > nums[i])
                {
                    nums.RemoveAt(i);
                }
            }
            if (nums.Count > 0)
            {
                for ( int i = nums.Count-1;i >= 0; i--)
                {
                    Console.Write($"{nums[i]}, ");
                }
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
