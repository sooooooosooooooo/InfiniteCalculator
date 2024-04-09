using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number:");
            string A = Console.ReadLine();
            Infinite a = new Infinite(A);
            Console.WriteLine("Please enter second number");
            string B = Console.ReadLine();
            Infinite b = new Infinite(B);
            Infinite c = new Infinite();
            Console.WriteLine("Please choose operator : '+' , '-' , '*' .");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "+":
                    c = Operators.Plus(a, b);
                    break;
                case "-":
                    c = Operators.Minus(a, b);
                    break;
                case "*":
                    c = Operators.Times(a, b);
                    break;
                default:
                    Console.WriteLine("Invalid input !");
                    break;
            }
            char symbol = c.Negativity == false ? ' ' : '-';
            if(string.Join("",c.Num) == "0") { symbol = ' '; }
            Console.WriteLine($"{A} {answer} {B} = {symbol}{string.Join("",c.Num)}");
        }
    }
}
