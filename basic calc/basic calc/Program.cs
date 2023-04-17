using System;

class Program
{
    static void Main(string[] args)
    {
        //Input for calc
        Console.WriteLine("Basic Calculator Program");

        Console.Write("Enter the first integer: ");
        int var1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int var2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the operator: ");
        string op = Console.ReadLine();

        //Math for calc
        if(var2 == 0 && op == "/")
        {
            Console.WriteLine("Error: cannot divide by zero.");
        }

        else if(op == "/" || op == "+" || op == "-" || op == "*" )
        {
            int result = 0; //result var

            if( op == "/" ) //divide math
            {
                result = var1 / var2;
            }

            if( op == "+" ) //addition math
            {
                result = var1 + var2;
            }

            if( op == "-" ) //subtraction math
            {
                result = var1 - var2;
            }

            if( op == "*" ) //Multiplication math
            {
                result = var1 * var2;
            }

            Console.WriteLine("The result is: " + result);
        }

        else
        {
            Console.WriteLine("Invalid operation.");
        }

        Console.ReadLine();
    }
}