using System;
using System.Security.Cryptography.X509Certificates;

public class Program {

    public static double ConvertToDouble(string input) {
        if (double.TryParse(input, out double result)) {
            return result;
        } else {
            System.Console.WriteLine("😤 Write a number, not whatever that is!!");
            Console.Write("Try again: "); 
            input = Console.ReadLine() ?? "0"; // If you do another readline here, you can make this loop until you get something sensible!
            return 0;
        }
    }
    public static string CalculationOutput(double num1, double num2, string op) {
        string output = "Final result: ";
        switch (op) {
            case "+":
                output += (num1 + num2).ToString();
                break;
            case "-":
                output += (num1 - num2).ToString();
                break;
            case "*":
                output += (num1 * num2).ToString();
                break;
            case "/":
                if (num2 == 0) {
                    output += "You can't divide by zero, dumb dumb!";
                } else {
                    output += (num1 / num2).ToString();
                }
                break;
            case "%":
                output += (num1 % num2).ToString();
                break;
            default:
                output += "Huh?";
                break;
        }
        return output;
    }

    public static void Main(string[] args) {
        System.Console.WriteLine("Type in your first number: ");
        string input1 = Console.ReadLine() ?? "0"; 
        double num1 = ConvertToDouble(input1); // Convert the input to a double, if it is a valid

        System.Console.WriteLine("Type in your ✨operator✨: ");
        string op = Console.ReadLine() ?? "+"; // If the input is null, set it to "+"

        System.Console.WriteLine("Type in your second number: ");
        string input2 = Console.ReadLine() ?? "0"; // If the input is null, set it to 0
        double num2 = ConvertToDouble(input2);
        
        System.Console.WriteLine("Doing some magic... 🪄✨");
        System.Console.WriteLine(CalculationOutput(num1, num2, op));
        System.Console.WriteLine("Calculation complete! Committing bye! Byeeeeeeee! 👋"); 
        
    }
}