namespace ielsenesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your leg size:");

            int number = 40;

            if (number < 30)
            {
                Console.WriteLine("Can't be that small");
            }
            else if (number >= 30 && number <= 33)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your leg size = " + number);
            }
            else if (number >= 34 && number <= 38)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Your leg size = " + number);
            }
            else if (number >= 39 && number <= 44)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Your leg size = " + number);
            }
            else if (number >= 45 && number <= 48)
            {
                Console.Beep();
                Console.WriteLine("Your leg size = " + number);
            }
            else
            {
                Console.WriteLine("Leg size is too large.");
            }


            Console.ResetColor();
        }
    }
}