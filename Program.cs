using System;

namespace Lab_2_1_Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");

            char repeat = 'y';
            const double HEIGHT = 10;

            while (repeat == 'y')
            {
                Console.Write("Enter Length: ");
                string input = Console.ReadLine();
                double length = double.Parse(input);

                Console.Write("Enter Width: ");
                input = Console.ReadLine();
                double width = double.Parse(input);

                double perimeter = 2 * length + 2 * width;
                double area = length * width;

                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);

                if (area <= 250)
                {
                    Console.WriteLine("This is a small room.");
                }
                else if (area > 250 && area < 650)
                {
                    Console.WriteLine("This is a medium room.");
                }
                else
                {
                    Console.WriteLine("This is a Large room.");
                }
                Console.Write("Would you like to calculate another room (y/n): ");
                input = Console.ReadLine();
                repeat = char.Parse(input);

            }
        }
    }
}
