using System;

namespace ultimate_calc
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ultimate calculator!");
            Console.WriteLine("Created by NASA BOI (on youtube)");
            Console.WriteLine("");

            Console.Write("Enter your first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("The result is: ");
            Console.WriteLine(num1 + num2);
            Console.WriteLine("");
            Console.Write("Press any key to exit... ");
            Console.ReadKey();
        }
    }
}
