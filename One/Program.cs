using System;

namespace One
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args[0] == "1")
            {
                Console.WriteLine("Executing PartOne");
                PartOne();
            }
            else
            {
                Console.WriteLine("Executing PartTwo");
                PartTwo();
            }
        }

        private static void PartTwo()
        {
            int a = 0, b = 0, c = 0, d = 0, i = 0, n =0;
            while (true)
            {
                int number;
                try
                {
                    number = Int32.Parse(Console.ReadLine() ?? String.Empty);
                }
                catch (Exception e)
                {
                    break;
                }
                i++;
                
                switch (i % 4)
                {
                    case 0:
                        b += number;
                        c += number;
                        d += number;
                        if (b > a && i > 3)
                            n++;
                        a = 0;
                        break;
                    case 1:
                        a += number;
                        c += number;
                        d += number;
                        if (c > b && i > 3)
                            n++;
                        b = 0;
                        break;
                    case 2:
                        a += number;
                        b += number;
                        d += number;
                        if (d > c && i > 3)
                            n++;
                        c = 0;
                        break;
                    case 3:
                        a += number;
                        b += number;
                        c += number;
                        if (a > d && i > 3)
                            n++;
                        d = 0;
                        break;
                }
            }
            Console.WriteLine(n);
        }

        private static void PartOne()
        {
            int previousNumber = 0;
            int currentNumber = 0;
            int depth = 0;

            var running = true;
            do {
                try
                {
                    currentNumber = Int32.Parse(Console.ReadLine() ?? String.Empty);
                }
                catch (Exception)
                {
                    running = false;
                }

                if (previousNumber == 0)
                {
                    Console.WriteLine($"{currentNumber} n/a");
                }
                else
                {
                    if (previousNumber < currentNumber)
                    {
                        depth++;
                        Console.WriteLine($"{currentNumber} (increased) now at {depth}");
                    }
                    else
                    {
                        Console.WriteLine($"{currentNumber} (decreased)");
                    }
                }
                previousNumber = currentNumber;
            } while (running);
            Console.WriteLine($"Got deeper {depth} times");
        }
    }
}