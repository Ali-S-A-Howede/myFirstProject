using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace returnFunction
{
    class Program
    {
        static double addNumbers2 (double myfirstNumber,double mySecondNumber)
        {
            double temp = myfirstNumber + mySecondNumber;
            return temp;
        }
        static void Main(string[] args)
        {
            double firstNumber = 17,secondNumber = 23;
            //int temp;
            //addNumbers2(number1, number2);
            //temp = addNumbers2(number1 + number2);
            Console.WriteLine($"{addNumbers2 (firstNumber , secondNumber)}");
            Console.ReadKey();
        }

        
    }
}
