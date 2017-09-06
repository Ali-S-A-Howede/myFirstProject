using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 5;
            double myDouble = 5.5;
            string myString = "Ali";
            bool myBool = true;
            char myChar = 'a';

            //If we want to know the range of the varible float or any varibles by code
            //float minFloat = float.MinValue;
            //float maxFlaot = float.MaxValue;
            //Console.WriteLine("Min Value={0} and Max value={1}", minFloat, maxFlaot);
            //Console.ReadKey();

            float floatVar = 1f / 3;
            double doubleVar = 1d / 3;
            decimal decimalVar = 1m / 3;
            Console.WriteLine("float Value={0}\n  double Value={1}\n decimal value={2}", floatVar, doubleVar,decimalVar);
            Console.ReadKey();

        }
    }
}
