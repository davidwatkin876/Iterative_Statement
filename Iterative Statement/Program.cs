namespace Iterative_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter an integer positive number between 1 and 100: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The number is invalid. Please try again.");
                }
            }

            // Specify the series type odd or even
            Console.WriteLine("Specify the series (Odd/Even): ");
            // Using Lower class so user can enter the series for the input.
            string series = Console.ReadLine().ToLower();

            Console.WriteLine("You have selected the ", series, " series. The numbers between 0 and ", num, " are: ");
            if (series == "odd")
            {
                for (int i = 1; i <= num; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            if (series == "even")
            {
                for (int i = 1; i <= num; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}