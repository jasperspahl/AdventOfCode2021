using System;
using System.IO;
using System.Linq;

namespace Three
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args[0] == "1")
            {
                PartOne();
            }
            else
            {
                PartTwo();
            }
        }

        private static void PartOne()
        {
            using var filestream = new StreamReader($"{Directory.GetCurrentDirectory()}/Input.txt");
            var input = filestream.ReadLine();

            int[] nums = new int[input.Length];
            while (true)
            {
                for (var i = 0; i < nums.Length; i++)
                {
                    if (input[i] == '0')
                    {
                        nums[i]--;
                    }
                    else
                    {
                        nums[i]++;
                    }
                }

                input = filestream.ReadLine();
                if (input == null)
                    break;
            }

            var arr = nums.Select(x => x > 0).ToArray();
            Console.WriteLine(string.Join(", ", nums));
            int gamma = Convert.ToInt32(new string(arr.Select(x => x ? '1' : '0').ToArray()), 2);
            Console.WriteLine(new string(arr.Select(x=>x?'1':'0').ToArray()));
            Console.WriteLine($"{Convert.ToString((int)gamma, 2)} Gamma {gamma} ");
            int epsilon = Convert.ToInt32(new string(arr.Select(x => x ? '0' : '1').ToArray()), 2);
            Console.WriteLine(new string(arr.Select(x=>x?'0':'1').ToArray()));
            Console.WriteLine($"{Convert.ToString((int)epsilon, 2)} Epsilon {epsilon} ");
            Console.WriteLine(gamma * epsilon);
        }
        
        private static void PartTwo()
        {
            throw new System.NotImplementedException();
        }
    }
}