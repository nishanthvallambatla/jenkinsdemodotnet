using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.QualityTools.UnitTestFramework;
namespace ConsoleApplication2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program programVar = new Program();
            int number1, number2, choice, result;
            Console.WriteLine("Calculator Console App");
            Console.WriteLine("Enter number 1");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("// Choose a option //");
            Console.WriteLine("1 - Add");
            Console.WriteLine("2 - Subtract");
            Console.WriteLine("3 - Mutiply");
            Console.WriteLine("4 - Divide");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: Console.WriteLine("Result");
                    result = programVar.Addition(number1, number2);
                    Console.WriteLine(result);
                    break;
                case 2: Console.WriteLine("Result");
                    result = programVar.Subtraction(number1, number2);
                    Console.WriteLine(result);
                    break;
                case 3: Console.WriteLine("Result");
                    result = programVar.Multiplication(number1, number2);
                    Console.WriteLine(result);
                    break;
                case 4: Console.WriteLine("Result");
                    result = programVar.Division(number1, number2);
                    Console.WriteLine(result);
                    break;
                default: Console.WriteLine("Wrong choice!");
                    break;
            }
            Console.ReadKey();
        }
        public int Addition(int number1, int number2)
        {
            return number2 + number1;
        }
        public int Subtraction(int number1, int number2)
        {
            return number1 - number2;
        }
        public int Multiplication(int number1, int number2)
        {
            return number2 * number1;
        }
        public int Division(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}
