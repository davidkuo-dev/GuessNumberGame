namespace GuessNumberApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int secret = rng.Next(0, 100);
            int min = 0;
            int max = 99;

            while (true)
            {
                if ((min == max && min != secret) || min > max)
                {
                    Console.WriteLine("GG.");
                    break;
                }

                Console.WriteLine($"({min}, {max})?");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int guess))
                {
                    if (guess < min || guess > max)
                    {
                        Console.WriteLine("Out of range. Try again?");
                        continue;
                    }

                    if (guess == secret)
                    {
                        Console.WriteLine("Bingo.");
                        break;
                    }
                    else if (guess < secret)
                    {
                        min = guess + 1;
                    }
                    else
                    {
                        max = guess - 1;
                    }
                }
                else
                {
                    Console.WriteLine("Out of range. Try again?");
                }
            }
        }
    }
}

