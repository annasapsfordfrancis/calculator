using System;

namespace calculator
{
    class Calculation
    {
        public decimal Num1
        { get; set; }
        public decimal Num2
        { get; set; }
        public decimal Result
        { get; set; }
        public int CalculationChoice
        { get; set; }
        public string? CalculationOperator
        { get; set; }
        public string? CalculationMessage
        { get; set; }

        public void Calculate()
        {
            switch (this.CalculationChoice)
            {
                case 1:
                    this.Add();
                    Console.WriteLine(this.CalculationMessage);
                    break;
                case 2:
                    this.Subtract();
                    Console.WriteLine(this.CalculationMessage);
                    break;
                case 3:
                    this.Multiply();
                    Console.WriteLine(this.CalculationMessage);
                    break;
                case 4:
                    this.Divide();
                    Console.WriteLine(this.CalculationMessage);
                    break;
                default:
                    break;
            }
        }

        public void GenerateCalculationMessage(decimal x, decimal y, decimal result, string calculation_operator)
        {
            this.CalculationMessage = $"Result:\n{x} {calculation_operator} {y} = {result}";
        }

        public void Add()
        {
            this.Result = this.Num1 + this.Num2;
            this.CalculationOperator = "+";
            GenerateCalculationMessage(this.Num1, this.Num2, this.Result, this.CalculationOperator);
        }

        public void Subtract()
        {
            this.Result = this.Num1 - this.Num2;
            this.CalculationOperator = "-";
            this.GenerateCalculationMessage(this.Num1, this.Num2, this.Result, this.CalculationOperator);
        }

        public void Multiply()
        {
            this.Result = this.Num1 * this.Num2;
            this.CalculationOperator = "*";
            GenerateCalculationMessage(this.Num1, this.Num2, this.Result, this.CalculationOperator);
        }

        public void Divide()
        {
            this.Result = this.Num1 / this.Num2;
            this.CalculationOperator = "/";
            GenerateCalculationMessage(this.Num1, this.Num2, this.Result, this.CalculationOperator);
        }
    }
}