namespace Premahvane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи числа = ");
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int last = nums[nums.Count - 1];
            for (int i = nums.Count - 1; i >= 0; i--)
            {
                if (nums[i] == last)
                {
                    nums.RemoveAt(i);
                }
            }
            Console.WriteLine(string.Join(' ' , nums));
        }
    }
}
