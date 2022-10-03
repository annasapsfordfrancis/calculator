// Welcome message.
string banner = @"   ______      __           __      __            
  / ____/___ _/ /______  __/ /___ _/ /_____  _____
 / /   / __ `/ / ___/ / / / / __ `/ __/ __ \/ ___/
/ /___/ /_/ / / /__/ /_/ / / /_/ / /_/ /_/ / /    
\____/\__,_/_/\___/\__,_/_/\__,_/\__/\____/_/     
                                                  ";
string divider = "------------------------------------";

Console.WriteLine(banner);

// Getting and validating numbers.
Console.Write("Please enter the first number: ");
var num1_input = Console.ReadLine();
decimal num1;

while (!decimal.TryParse(num1_input, out num1))
{
    Console.WriteLine("Please enter a number");
    num1_input = Console.ReadLine();
}

Console.Write("Please enter the second number: ");
var num2_input = Console.ReadLine();

decimal num2;
while (!decimal.TryParse(num2_input, out num2))
{
    Console.WriteLine("Please enter a number");
    num2_input = Console.ReadLine();
}

Console.WriteLine(divider);

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

Console.WriteLine(divider);

// Calculating and displaying result.
decimal result;
string calculation_operator = "";

switch (calculation_choice)
{
    case 1:
        calculation_operator = "+";
        result = Add(num1, num2);
        Console.WriteLine(GetCalculationMessage(num1, num2, result, calculation_operator));
        break;
    case 2:
        calculation_operator = "-";
        result = Subtract(num1, num2);
        Console.WriteLine(GetCalculationMessage(num1, num2, result, calculation_operator));
        break;
    case 3:
        calculation_operator = "*";
        result = Multiply(num1, num2);
        Console.WriteLine(GetCalculationMessage(num1, num2, result, calculation_operator));
        break;
    case 4:
        calculation_operator = "/";
        result = Divide(num1, num2);
        Console.WriteLine(GetCalculationMessage(num1, num2, result, calculation_operator));
        break;
    default:
        break;
}


static decimal Add(decimal x, decimal y)
{
    return x + y;
}

static decimal Subtract(decimal x, decimal y)
{
    return x - y;
}

static decimal Multiply(decimal x, decimal y)
{
    return x * y;
}

static decimal Divide(decimal x, decimal y)
{
    return x / y;
}

static string GetCalculationMessage(decimal x, decimal y, decimal result, string calculation_operator)
{
    return $"Result:\n{x} {calculation_operator} {y} = {result}";
}