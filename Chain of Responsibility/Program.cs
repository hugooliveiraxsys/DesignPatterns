using System;

namespace Chain_of_Responsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chain of Responsibility");

            Handler calculatorHandler = new CalculatorHandler(); 
            Handler sumhandler = new SumHandler();
            Handler substracthandler = new SubtractHandler();
            Handler multiplierhandler = new MultiplierHandler();

            calculatorHandler.SetNextHandler(sumhandler);
            sumhandler.SetNextHandler(substracthandler);
            substracthandler.SetNextHandler(multiplierhandler);

            calculatorHandler.HandlerRequest(2, 3, EOperation.Sum);
            calculatorHandler.HandlerRequest(2, 3, EOperation.Subtract);
            calculatorHandler.HandlerRequest(2, 3, EOperation.Multiplier);

            Console.WriteLine("Fim");
        }
    }
}
