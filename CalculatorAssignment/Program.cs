using System;
using static System.Console;

namespace CalculatorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool running = true;
            int menu = 0;
            
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
                        Add();
                        break;
                    case 2:
                        Subtract();
                        break;
                    case 3:
                        Division();
                        break;
                    case 4:
                        Multiply();
                        break;
                    case 5:
                        PowerOf();
                        break;
                    case 6:
                        SquareRoot();
                        break;
                    default:
                        ErrorMsg();
                        break;

                }

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
        static int GetNumberFromUser()
        {
            int userInput = 0;
            bool success = false;
            while (!success)
            {
                WriteLine("\nEnter number:");
                success = int.TryParse(ReadLine(), out userInput);
            }

            return userInput;
        }

        //Ask user for any amount of numbers and add them together
        static double Add ()
        {
            bool SumUp = false;
            double num, sum = 0D;
            EnterNumMsg();
            WriteLine("Type 'exit' to calculate.");
            
            while (!SumUp)
            {
                string text = ReadLine();
                if (text.ToLower() == "exit")
                {
                    SumUp = true;
                }
                else if (double.TryParse(text, out num))
                {
                    sum += num;
                } else
                {
                    ErrorMsg();
                }
            }

            WriteLine("Your sum is {0}", sum);

            return 0;
        }

        static int Subtract ()
        {
            EnterNumMsg();
            int firstNum = GetNumberFromUser();
            int secondNum = GetNumberFromUser();
            int sum = firstNum - secondNum;

            WriteLine("Your sum is {0}", sum);
            return sum;
        }

        static double Division()
        {
            EnterNumMsg();
            int firstNum = GetNumberFromUser();
            int divisionNum = GetNumberFromUser();

            while (divisionNum == 0)
            {
                WriteLine("Can't divide by 0.");
                divisionNum = GetNumberFromUser();
            }

            WriteLine("Your sum is {0}", (double) firstNum / divisionNum);
            return 0;
        }

        static int Multiply()
        {
            EnterNumMsg();
            int firstNum = GetNumberFromUser();
            int secondNum = GetNumberFromUser();
            
            int sum = firstNum * secondNum;
            
            WriteLine("Your sum is {0}", sum);
            return sum;
        }

        static double PowerOf()
        {
            EnterNumMsg();
            int firstNum = GetNumberFromUser();
            int secondNum = GetNumberFromUser();

            double sum = Math.Pow(firstNum, secondNum);

            WriteLine("Your sum is {0}", sum);
            return sum;
        }

        static double SquareRoot()
        {
            EnterNumMsg();
            double firstNum = GetNumberFromUser();

            double sum = Math.Sqrt(firstNum);

            WriteLine("Square root is {0}", sum);
            return sum;
        }

    }
}
