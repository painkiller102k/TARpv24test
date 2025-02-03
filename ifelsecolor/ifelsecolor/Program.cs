using System;


namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your color - ");
            string color = Console.ReadLine();
            

            if (color == "red" || color == "green" || color == "white" || color == "blue")
            {
              Console.WriteLine("Color that you chose is - " + color);
            }
            else
            {
            Console.WriteLine("You cant choose this color!");
                Console.Beep();
            }
        }
    }
}


