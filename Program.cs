using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1.2.3 (switch)

            bool keepRunning = true;

            while (keepRunning)
            {

                Console.WriteLine("This program will run basic calculator functions");
                Console.WriteLine("Press ENTER to proceed");
                Console.ReadLine();

                Console.WriteLine("Select calculator function (1-4) from the below menu:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                
                string userInput = Console.ReadLine();

                switch (userInput)

                {
                    case "1":
                        Console.WriteLine("Input the first number and press ENTER");
                        double doubleValue1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Input the second number and press ENTER");
                        double doubleValue2 = Convert.ToDouble(Console.ReadLine());
                        double sum = doubleValue1 + doubleValue2;
                        Console.WriteLine("The sum of the two numbers is " + sum);
                        break;

                    case "2":
                        Console.WriteLine("Input the first number and press ENTER");
                        double doubleValue3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Input the second number and press ENTER");
                        double doubleValue4 = Convert.ToDouble(Console.ReadLine());
                        double difference = doubleValue3 - doubleValue4;
                        Console.WriteLine("The difference between the two numbers is " + difference);
                        break;

                    case "3":
                        Console.WriteLine("Input the first number and press ENTER");
                        double doubleValue5 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Input the second number and press ENTER");
                        double doubleValue6 = Convert.ToDouble(Console.ReadLine());
                        double product = doubleValue5 * doubleValue6;
                        Console.WriteLine("The product of the two numbers is " + product);
                        break;

                    case "4":
                        Console.WriteLine("Input the first number and press ENTER");
                        double doubleValue7 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Input the second number and press ENTER");
                        double doubleValue8 = Convert.ToDouble(Console.ReadLine());
                        double quotient = doubleValue7 / doubleValue8;
                        Console.WriteLine("The quotient of the two numbers is " + quotient);
                        break;

                    case "5":
                        keepRunning = false;
                        Console.WriteLine("Goodbye!");
                        break;



                }
            }
        }
    }
}










