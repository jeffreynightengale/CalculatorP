using System;

namespace Calculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            DeveloperInformation("", "", "");

            string final;
            Console.WriteLine("Would you like to do addition, subtraction, mulitplication, " +
                              " or division?");
            string oper = Console.ReadLine().ToLower();

            Console.WriteLine("What is your first value?");
            string firstVal = Console.ReadLine();
            double v1;
            while (double.TryParse(firstVal, out v1) == false)
            {
                Console.WriteLine("Please input a number");
                firstVal = Console.ReadLine();
            }

            Console.WriteLine("What is your second value?");
            string secondVal = Console.ReadLine();
            double v2;
            while (double.TryParse(secondVal, out v2) == false)
            {
                Console.WriteLine("Please input a number");
                secondVal = Console.ReadLine();
            }

            do
            {
                double answer = 0;
                if (oper == "addition")
                {
                    answer = Add(v1, v2);
                    Console.WriteLine($"{v1} + {v2} = {answer}");
                }
                else if (oper == "subtraction")
                {
                    answer = Subtract(v1, v2);
                    Console.WriteLine($"{v1} - {v2} = {answer}");
                }
                else if (oper == "multiplication")
                {
                    answer = Multiply(v1, v2);
                    Console.WriteLine($"{v1} * {v2} = {answer}");
                }
                else if (oper == "division")
                {
                    answer = Divide(v1, v2);
                    Console.WriteLine($"{v1} / {v2} = {answer}");
                }

                Console.WriteLine("Would you like to do another problem?");
                final = Console.ReadLine();
                if (final.ToLower()[0] == 'n')
                {
                    Console.WriteLine("Thank you for using our Calculator!");
                    Environment.Exit(-1);
                }

                Console.WriteLine("Would you like to keep the final answer as your first value?");
                string nextProblem = Console.ReadLine().ToLower();
                if (nextProblem.ToLower()[0] == 'y')
                {
                    v1 = answer;
                    Console.WriteLine("Would you like to do addition, subtraction, mulitplication, " +
                              " or division?");
                    oper = Console.ReadLine().ToLower();

                    Console.WriteLine("What is your second value?");
                    secondVal = Console.ReadLine();
                    while (double.TryParse(secondVal, out v2) == false)
                    {
                        Console.WriteLine("Please input a number");
                        secondVal = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Would you like to do addition, subtraction, mulitplication, " +
                              " or division?");
                    oper = Console.ReadLine().ToLower();

                    Console.WriteLine("What is your first value?");
                    firstVal = Console.ReadLine();
                    while (double.TryParse(firstVal, out v1) == false)
                    {
                        Console.WriteLine("Please input a number");
                        firstVal = Console.ReadLine();
                    }

                    Console.WriteLine("What is your second value?");
                    secondVal = Console.ReadLine();
                    while (double.TryParse(secondVal, out v2) == false)
                    {
                        Console.WriteLine("Please input a number");
                        secondVal = Console.ReadLine();
                    }
                }

                
            } while (final.ToLower()[0] == 'y');
        }

        static double Add(double v1, double v2)
        {
            return v1 + v2;
        }

        static double Subtract(double v1, double v2)
        {
            return v1 - v2;
        }

        static double Multiply(double v1, double v2)
        {
            return v1 * v2;
        }

        static double Divide(double v1, double v2)
        {
            return v1 / v2;
        }
        static void DeveloperInformation(string name, string className, string dateOfWriting)
        {
            name = "Jeffrey Nightengale";
            className = "MIS 3013";
            dateOfWriting = "July 27, 2021";

            Console.WriteLine($"{name}, {className}, {dateOfWriting}");
            Console.WriteLine();
        }
    }
}
