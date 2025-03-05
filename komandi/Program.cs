using System.Text;

namespace komandi
{
    internal class Program
    {
        static List<string> Reverse(List<string> arr)
        {
            //poluchavam masiv i vrushtam list ot oburnatiq masiv
            List<string> result = new List<string>();
            for (int i = arr.Count - 1; i >= 0; i--)
            {
                result.Add(arr[i]);
            }
            return result;
        }
        static List<string> Distinct(List<string> arr)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr.Contains(arr[i]) == false) ;
                {
                    result.Add(arr[i]);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            List<string> output = new List<string>(input); //suzdava se output
            //broi komandi
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                switch (command[0])
                {
                    case "Reverse": output = Reverse(output); break;
                    case "Distinct": output = Distinct(output); break;
                    case "Replace": 
                        {
                            int index = int.Parse(command[1]);
                            string element = command[2];
                            Replace(output, index, element);
                            break;
                        }
                    case "Insert":
                        {
                            int index = int.Parse(command[1]);
                            string element = command[2];
                            output.Insert(index, element); 
                            break;
                        }
                }

                Console.WriteLine(string.Join(", ", output));
            }
        }

        private static void Replace(List<string> List, int index, string element)
        {
            if (index < 0 || index > List.Count-1)
            {
                Console.WriteLine("nevaliden indek");
                return;
            }            
            List[index] = element;            
        }
    }
}
