using System;
using static System.Console;

namespace CalculatorAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            bool running = true;
            double menu = 0;
            double result = 0;
            double num1 = 0;
            double num2 = 0;
            string input = "";
            
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
                        EnterNumMsg();
                        input = ReadLine();
                        Add2(input);
                        break;
                    case 2:
                        EnterNumMsg();
                        num1 = GetNumberFromUser();
                        num2 = GetNumberFromUser();
                        result = Subtract(num1, num2);
                        break;
                    case 3:
                        EnterNumMsg();
                        num1 = GetNumberFromUser();
                        num2 = GetNumberFromUser();
                        result = Division(num1, num2);
                        break;
                    case 4:
                        EnterNumMsg();
                        num1 = GetNumberFromUser();
                        num2 = GetNumberFromUser();
                        result = Multiply(num1, num2);
                        break;
                    case 5:
                        EnterNumMsg();
                        num1 = GetNumberFromUser();
                        num2 = GetNumberFromUser();
                        result = PowerOf(num1, num2);
                        break;
                    case 6:
                        EnterNumMsg();
                        num1 = GetNumberFromUser();
                        result = SquareRoot(num1);
                        break;
                    default:
                        WriteLine("Something went wrong, try again.");
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

            do
            {
                try
                {
                    WriteLine("\nEnter number:");
                    success = double.TryParse(ReadLine(), out userInput);
                } catch(OverflowException)
                {
                    WriteLine("Your value is too big");
                }
                catch (ArgumentNullException)
                {
                    WriteLine("Could not parse, value was null");
                }
                catch (FormatException error)
                {
                    WriteLine(error.Message);

                    WriteLine("Wrong format");
                }

            } while (!success);

            return userInput;
        }

        public static double Add2(string input)
        {

            string splitInput = input.Replace(",", " ");
            WriteLine(splitInput);
            //double[] arr = new double[] { num1, num2 };
            double result = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    result += arr[i];
            //}

            //WriteLine("result is " + result);

            return result;
        }

        public static double Add(double num1, double num2)
        {
            double result = 0;
            result = num1 + num2;

            return result;
        }

        public static double Subtract(double num1, double num2)
        {
            double result = 0;
            result = num1 - num2;

            return result;
        }


        public static double Division(double num1, double num2)
        {
            double result = 0;
            bool success = false;

            //do
            //{
            //    try
            //    {
            //        if (num2 == 0)
            //        {
            //            throw new DivideByZeroException("Can't divide by 0, enter another number.");

            //        }
            //        else
            //        {
            //            result = num1 / num2;
            //            success = true;
            //        }

            //    }
            //    catch (DivideByZeroException)
            //    {
            //        WriteLine("Can't divide by 0, enter another number.");
            //        success = false;
            //        num2 = GetNumberFromUser();
            //    }

            //}
            //while (!success);

            if (num2 == 0)
            {
                throw new DivideByZeroException("Can't divide by 0, enter another number.");
            }

            result = num1 / num2;
            return result;
        }

        public static double Multiply(double num1, double num2)
        {
            double result = 0;
            result = num1 * num2;
            
            return result;
        }

        public static double PowerOf(double num1, double num2)
        {
            double result = 0;
            result = Math.Pow(num1, num2);

            return result;
        }

        public static double SquareRoot(double num1)
        {
            double result = 0;
            result = Math.Sqrt(num1);

            return result;
        }

    }
}
