using System; // this namespace contains fundamental classes and provides access to standard input/output capabilities

class Calculator 
{
    static void Main()
    {
        //Display welcome message
        Console.WriteLine("Welcome to the Calculator!");

        while (true)
        {
            // Prompting the user to enter the first number
            Console.WriteLine("Enter the first number:");
            double num1;
            bool isValidInput = double.TryParse(Console.ReadLine(), out num1);

            while (!isValidInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                isValidInput = double.TryParse(Console.ReadLine(), out num1);
            }


            // Prompting the user to choose an operator
            Console.WriteLine("Enter the operation (+, -, *, /):");
            string operation = Console.ReadLine();
            while (!(operation == "+" || operation == "-" || operation == "*" || operation == "/"))
            {
                Console.WriteLine("Invalid operation. Please enter a valid operation (+, -, *, /):");
                operation = Console.ReadLine();
            }
            // prompting the user to enter the second number
            Console.WriteLine("Enter the second number:");
            double num2;
            bool isValdInput = double.TryParse(Console.ReadLine(), out num2);

            while (!isValdInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                isValdInput = double.TryParse(Console.ReadLine(), out num2);
            }


            // referencing the performOperation method
            double result = PerformOperation(num1, num2, operation);
            Console.WriteLine($"Result: {result}");
            // checking if the user wants to perform another operation
            Console.WriteLine("Do you want to perform another calculation? (Y/N)");
            string input = Console.ReadLine();
            // checking the condition
            if (input.ToLower() != "y")
                break;
        }

        Console.WriteLine("Thank you for using the Calculator. Goodbye!");
    }
    // using the switch case to perform calculations
    static double PerformOperation(double num1, double num2, string operation)
    {
        double result = 0;

        switch (operation)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                result = num1 / num2;
                break;
        }

        return result;
    }
}

