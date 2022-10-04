using System;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Welcome message.
            string banner = @"   ______      __           __      __            
  / ____/___ _/ /______  __/ /___ _/ /_____  _____
 / /   / __ `/ / ___/ / / / / __ `/ __/ __ \/ ___/
/ /___/ /_/ / / /__/ /_/ / / /_/ / /_/ /_/ / /    
\____/\__,_/_/\___/\__,_/_/\__,_/\__/\____/_/     
                                                ";
            string divider = "------------------------------------";

            Console.WriteLine(banner);

            Calculation calc = new Calculation();

            // ToDo: refactor to class method
            // Getting and validating numbers.
            Console.Write("Please enter the first number: ");
            var num1_input = Console.ReadLine();
            decimal num1;

            while (!decimal.TryParse(num1_input, out num1))
            {
                Console.WriteLine("Please enter a number");
                num1_input = Console.ReadLine();
            }
            calc.Num1 = num1;

            Console.Write("Please enter the second number: ");
            var num2_input = Console.ReadLine();

            decimal num2;
            while (!decimal.TryParse(num2_input, out num2))
            {
                Console.WriteLine("Please enter a number");
                num2_input = Console.ReadLine();
            }
            calc.Num2 = num2;

            Console.WriteLine(divider);

            // ToDo: refactor to class method
            // Getting and validating calculation choice.
            Console.WriteLine("The following options are available:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Please enter the number of your choice: ");

            var calculation_choice_input = Console.ReadLine();
            int calculation_choice;

            while (true)
            {
                if (!int.TryParse(calculation_choice_input, out calculation_choice))
                {
                    Console.WriteLine("Please enter a number from 1 to 4.");
                    calculation_choice_input = Console.ReadLine();
                }
                else if (calculation_choice < 1 || calculation_choice > 4)
                {
                    Console.WriteLine("Please enter a number from 1 to 4.");
                    calculation_choice_input = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            calc.CalculationChoice = calculation_choice;

            Console.WriteLine(divider);

            // Calculating and displaying result.
            calc.Calculate();
        }
    }
}



