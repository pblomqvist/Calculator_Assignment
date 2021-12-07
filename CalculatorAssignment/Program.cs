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

            WriteLine("Welcome!\n");

            while (running)
            {
                WriteLine("Choose an option..");
                MenuOptions();
                menu = GetNumberFromUser();

                switch(menu)
                {
                    case 0:
                        WriteLine("Do you really want to exit?");
                        if (ReadLine() == "y")
                        {
                            running = false;
                            Environment.Exit(0);
                        } else
                        {
                            WriteLine("Not a valid answer");
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
                    default:
                        WriteLine("Invalid menu option. Try again!");
                        break;

                }

                
            }
        }

        static int Add ()
        {
            WriteLine("Write some numbers to add, separate with commas");
            int firstNum = GetNumberFromUser();
            int secondNum = GetNumberFromUser();
            int sum = firstNum + secondNum;

            WriteLine("Your sum is {0}", sum);

            return 0;

        }


        static int Subtract ()
        {
            WriteLine("Write numbers 2 numbers to subtract");
            int firstNum = GetNumberFromUser();
            int secondNum = GetNumberFromUser();

            int sum = firstNum - secondNum;

            WriteLine("Your sum is {0}", sum);
            return sum;
        }

        static double Division()
        {
            WriteLine("Write 2 numbers to divide");
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
            WriteLine("Write 2 numbers to multiply");
            int firstNum = GetNumberFromUser();
            int secondNum = GetNumberFromUser();
            
            int sum = firstNum * secondNum;
            
            WriteLine("Your sum is {0}", sum);
            return sum;
        }

        static void MenuOptions()
        {
            string[] menuOpts = { "Exit", "Add", "Subtract", "Division", "Multiply" };
            

            for (int i = 0; i < menuOpts.Length; i++) {
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
    }
}
