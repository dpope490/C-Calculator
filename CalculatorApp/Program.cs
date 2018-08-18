using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNum = 0;
            int check = 0;
            
            Console.WriteLine("Welcome to the Calculator App!");
            Program calculation = new Program();
            calculation.enterDigits(endNum, check);
            Console.WriteLine("Press any key to end the program.");
            Console.ReadKey();

        }

        public int performOperation(int num1, int num2, int endNum, string operation)
        {
            switch (operation)
            {
                case "+":
                    endNum = num1 + num2;
                    break;
                case "-":
                    endNum = num1 - num2;
                    break;
                case "*":
                    endNum = num1 * num2;
                    break;
                case "/":
                    endNum = num1 / num2;
                    break;
                case "%":
                    endNum = num1 % num2;
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
            return endNum;
        }

        public void enterDigits(int endNum, int check)
        {
            int num1;
            if (check == 0)
            {
                Console.WriteLine("Enter the first number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                num1 = endNum;
            }
            check++;
            Console.WriteLine("Perform an operation (enter one of the operators below) ");
            Console.WriteLine("+ - * / %");
            string operation = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            endNum = performOperation(num1, num2, endNum, operation);
            Console.WriteLine($"The finished number is {endNum}");
            Console.WriteLine("Do you want to perform more operations?");
            Console.WriteLine("Type y for yes or n for no");
            char continueOperation = Convert.ToChar(Console.ReadLine());
            if (continueOperation == 'y')
            {
                Console.WriteLine("Do you want to use the finished number?");
                Console.WriteLine("Type y for yes or n for no");
                char useEndNum = Convert.ToChar(Console.ReadLine());
                if (useEndNum == 'y')
                {
                    enterDigits(endNum, check);
                }
                else
                {
                    check = 0;
                    enterDigits(endNum, check);
                }
            }
        }
    }
}
