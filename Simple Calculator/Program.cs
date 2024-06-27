namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            double firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose an operation: +, -, *, /");
            string operationInput = Console.ReadLine();

            switch (operationInput)
            {
                case "+":
                    Console.WriteLine($"Result: {(firstNum + secondNum)}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {(firstNum - secondNum)}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {(firstNum * secondNum)}");
                    break;
                case "/":
                    if (firstNum == 0 || secondNum == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed");
                        break;
                    }
                    Console.WriteLine($"Result: {(firstNum / secondNum)}");
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                    break;
            }
        }
    }
}
