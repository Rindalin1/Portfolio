// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;


    class Program
    { 
       static void Main(string[] args)
{
            try
{
            string value;
                 do
           {
             int res;
             Console.Write("Enter a number: ");
             int number = int.Parse(Console.ReadLine());

             Console.Write("Enter second number: ");
             int number2 = int.Parse(Console.ReadLine());

  
            string[] symbols = {"/", "*", "+", "-",};

             foreach (string symbol in symbols)
           {
              Console.WriteLine(symbol);
                                         }
           Console.WriteLine("Enter the method of symbols provided");
           string Symbol = Console.ReadLine(); 

            switch (Symbol)
           {
             case "+":
             res = number+number2;
             Console.WriteLine("Addition: " + res);
             break;
             case "/":
            res = number/number2;
            Console.WriteLine("Divide: " + res);
             break;
             case "*":
             res = number*number2;
            Console.WriteLine("Multiplication: " + res);
            break;
            case "-":
            res = number-number2;
            Console.WriteLine("Subract: " + res);
            break;        
            default:
            Console.WriteLine("Wrong input");
            break;
    }
    
    Console.Write("Do you want to do another equation:  (y/n)");
    value = Console.ReadLine();
           }

   while (value=="y" || value=="Y");
   
        } 
        catch (FormatException)
        {
          Console.WriteLine("Invalid input");
        } 
        catch (DivideByZeroException)
        {
          Console.WriteLine("Cannot divide by zero!");
        }  
}
 }
