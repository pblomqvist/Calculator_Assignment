using System;
using static System.Console;

namespace CalculatorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool running = true;
            double menu = 0;
            double result = 0;
            
            WriteLine("Welcome!");

            while (running)
            {
                MenuOptions();
                menu = GetNumberFromUser();

                //Different cases with individual operations a user can pick from
                switch(menu)
                {
                    case 0:
                        WriteLine("Do you really wish to exit? Type 'y' to confirm.");
                        if (ReadLine() == "y")
                        {
                            running = false;
                            Environment.Exit(0);
                        } else
                        {
                            ErrorMsg();
                            WriteLine("Continuing program...\n");
                        }
                        break;
                    case 1:
                        result = Add(result);
                        break;
                    case 2:
                        result = Subtract(result);
                        break;
                    case 3:
                        result = Division(result);
                        break;
                    case 4:
                        result = Multiply(result);
                        break;
                    case 5:
                        result = PowerOf(result);
                        break;
                    case 6:
                        result = SquareRoot(result);
                        break;
                    default:
                        ErrorMsg();
                        break;

                }

                WriteLine("\nThe result is {0}", result);
                
            }
        }

        static void ErrorMsg()
        {
            WriteLine("\nNot a valid answer.");
        }

        static void EnterNumMsg()
        {
            WriteLine("\nPlease enter your number/s");
        }

        // Display menu by iterating through the array and print each as an option
        static void MenuOptions()
        {

            WriteLine("\nChoose an option..");
            string[] menuOpts = { "Exit", "Add", "Subtract", "Division", "Multiply", "Power of", "Square root" };

            for (int i = 0; i < menuOpts.Length; i++)
            {
                WriteLine("#{0}  {1}", i, menuOpts[i]);
            }

        }

        // Takes input from user and runs until a valid number is entered
        static double GetNumberFromUser()
        {
            double userInput = 0;
            bool success = false;
            while (!success)
            {
                WriteLine("\nEnter number:");
                success = double.TryParse(ReadLine(), out userInput);
            }

            return userInput;
        }

        //Ask user for any amount of numbers and add them together
        static double Add (double result)
        {
            bool countResult = false;
            EnterNumMsg();
            WriteLine("Type 'quit' to add everything together.");
            
            while (!countResult)
            {
                string userInput = ReadLine();
                if (userInput.ToLower() == "quit")
                {
                    countResult = true;
                }
                else if (double.TryParse(userInput, out double addNum))
                {
                    result += addNum;
                } else
                {
                    ErrorMsg();
                }
            }

            return result;
        }

        static double Subtract (double result)
        {
            EnterNumMsg();
            double firstNum = GetNumberFromUser();
            double secondNum = GetNumberFromUser();
            
            result = firstNum - secondNum;

            return result;
        }

        static double Division(double result)
        {
            EnterNumMsg();
            double firstNum = GetNumberFromUser();
            double divisionNum = GetNumberFromUser();

            while (divisionNum == 0)
            {
                WriteLine("Can't divide by 0, enter another number.");
                divisionNum = GetNumberFromUser();
            }

            result = (double)firstNum/divisionNum;

            return result;
        }

        static double Multiply(double result)
        {
            EnterNumMsg();
            double firstNum = GetNumberFromUser();
            double secondNum = GetNumberFromUser();
            
            result = firstNum * secondNum;
            
            return result;
        }

        static double PowerOf(double result)
        {
            EnterNumMsg();
            double firstNum = GetNumberFromUser();
            double secondNum = GetNumberFromUser();

            result = Math.Pow(firstNum, secondNum);

            return result;
        }

        static double SquareRoot(double result)
        {
            EnterNumMsg();
            double firstNum = GetNumberFromUser();

            result = Math.Sqrt(firstNum);

            return result;
        }

    }
}
