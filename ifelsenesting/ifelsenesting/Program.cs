namespace ifelsenesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Control!");

            int number = 189;

            if (number > 189)
            {
                Console.WriteLine("Number is bigger");

                if (number > 190 && number < 200)
                {
                    Console.WriteLine("Number is between 190 and 200");
                }
            }
            else
            {
                Console.WriteLine("Number is smaller");
            }
        }
     }
}



