using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac3task2
{
    static public class Calculator
    {
        public delegate double Calc(double x, double y);

        static public double Process(double x, double y, Calc function)
        {
            Calc func = new Calc(function);
            return func(x,y);
        }
    }
    class Program
    {
        static private double handlerAdd(double x, double y)
        {
            return x + y;
        }

        static private double handlerMul(double x, double y)
        {
            return x * y;
        }

        static private double handlerDiv(double x, double y)
        {
                if (y != 0)
                    return x / y;
                else throw new Exception();            
        }

        static private double handlerSub(double x, double y)
        {
            return x - y;
        }

        static void Main(string[] args)
        {
           
            Console.WriteLine(Calculator.Process(1,2,handlerAdd));
            Console.WriteLine(Calculator.Process(8, 3, handlerDiv));
            Console.WriteLine(Calculator.Process(5, 4, handlerMul));
            Console.WriteLine(Calculator.Process(-3, 5, handlerAdd));
            Console.Read();
        }
    }
}
