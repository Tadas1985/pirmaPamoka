using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmaPamoka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Console.WriteLine("Task 1");
            Console.WriteLine("What is your favorite color");
            string color = Console.ReadLine();
            Console.WriteLine($"{color}, mine too!");
            Console.ReadKey();

            // Task 2
            Console.WriteLine("Task 2");
            Console.WriteLine($"Sum of 17 and 23 is: {17 +23}");
            Console.ReadKey(true);

            // Task 3
            Console.WriteLine("Task 3");
            double firstNum = 24;
            double secondNum = 5;
            Console.WriteLine($"Division of 24 / 5 is {firstNum/secondNum}");
            Console.ReadKey();

            // Task 4
            Console.WriteLine("Task 4");
            Console.WriteLine($"-6 + 3 * 5 = {-6 + 3 * 5}");
            Console.WriteLine($"(13 - 2) * 7 = {(13 - 2) * 7}");
            Console.WriteLine($"(5 + -2)+(20/10) = {(5 + -2) + (20 / 10)}");
            Console.ReadKey();

            // Task 5 
            Console.WriteLine("Task 5");
            Console.WriteLine("Enter first number:");
            int numA  =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int numB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{numA} * {numB} = {numA * numB}");
            Console.WriteLine($"{numA} / {numB} = {Convert.ToDouble(numA) / Convert.ToDouble(numB)}");
            Console.WriteLine($"{numA} + {numB} = {numA + numB}");
            Console.WriteLine($"{numA} - {numB} = {numA - numB}");
            Console.ReadLine();

            // Task 6
            Console.WriteLine("Task 6");
            Console.WriteLine("Enter a number");
            int numberC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{numberC} * 0 = {numberC * 0}"); 
            Console.WriteLine($"{numberC} * 1 = {numberC * 1}"); 
            Console.WriteLine($"{numberC} * 2 = {numberC * 2}"); 
            Console.WriteLine($"{numberC} * 3 = {numberC * 3}"); 
            Console.WriteLine($"{numberC} * 4 = {numberC * 4}"); 
            Console.WriteLine($"{numberC} * 5 = {numberC * 5}"); 
            Console.WriteLine($"{numberC} * 6 = {numberC * 6}"); 
            Console.WriteLine($"{numberC} * 7 = {numberC * 7}"); 
            Console.WriteLine($"{numberC} * 8 = {numberC * 8}"); 
            Console.WriteLine($"{numberC} * 9 = {numberC * 9}");
            Console.ReadLine();

            // Task 7
            Console.WriteLine("Task 7");
            int numberOne, numberTwo, numberThree, numberFour;
            Console.WriteLine("Enter first number");
            numberOne = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            numberTwo = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third number");
            numberThree = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter fourth number");
            numberFour = (int)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The mean of numbers {numberOne}, {numberTwo}, {numberThree}, {numberFour} is {(Convert.ToDouble(numberOne) + Convert.ToDouble(numberTwo) + Convert.ToDouble(numberThree) + Convert.ToDouble(numberFour)) / 4}");
            Console.ReadLine();

            // Task 8
            Console.WriteLine("Task 8");
            Console.WriteLine("Enter number A:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number B:");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number C:");
            int C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"({A} + {B}) * C = {(A + B) * C}");
            Console.WriteLine($"{A} * {C} + {B} * {C} = {A * C + B * C}");
            Console.ReadLine();
        }
    

    }
}
