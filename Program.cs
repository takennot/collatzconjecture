namespace CollatzConjecture;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("________________________________________");
            Console.WriteLine("Enter a number that is bigger than 1: ");
            long num;
            int steps = 0;
            bool success = Int64.TryParse(Console.ReadLine(), out num);
            if (success && num > 1)
            {
                while(num != 1)
                {
                    steps++;
                    if (num % 2 == 0)
                    {
                        Console.WriteLine("num = " + num);
                        num /= 2;
                        Console.WriteLine("#" + steps + ". num / 2 = " + num);
                    }
                    else
                    {
                        Console.WriteLine("num = " + num);
                        num *= 3;
                        num += 1;
                        Console.WriteLine("#" + steps + ". num * 3 + 1 = " + num);
                    }
                    if (num > Int64.MaxValue || num < 0)
                    {
                        Console.WriteLine("Number got outside of acceptable values, try again with smaller numbers");
                        steps = 0;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter a valid number!");
            }
            if (steps > 0)
            {
                Console.WriteLine(steps + " steps done to get 1");
            }
        }
    }
}
