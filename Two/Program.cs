using System;

namespace Two
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
            int x = 0, y = 0;
            while (true)
            {
                var input = Console.ReadLine() ?? "stop";
                var strings = input.Split(" ");
                if (strings[0] == "stop")
                    break;
                switch (strings[0])
                {
                    case "forward":
                        x += Int32.Parse(strings[1]);
                        break;
                    case "down":
                        y += Int32.Parse(strings[1]);
                        break;
                    case "up":
                        y -= Int32.Parse(strings[1]);
                        break;
                }
            }
            Console.WriteLine(x * y);
        }
        
        private static void PartTwo()
        {
            int x = 0, y = 0, aim = 0;
            while (true)
            {
                var input = Console.ReadLine() ?? "stop";
                var strings = input.Split(" ");
                if (strings[0] == "stop")
                    break;
                switch (strings[0])
                {
                    case "forward":
                        var num = int.Parse(strings[1]);
                        x += num;
                        y += aim * num;
                        break;
                    case "down":
                        aim += Int32.Parse(strings[1]);
                        break;
                    case "up":
                        aim -= Int32.Parse(strings[1]);
                        break;
                }
            }
            Console.WriteLine(x * y);
        }
    }
}