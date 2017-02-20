using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace prac4task1
{
    public class CalcException : Exception
    {
        public CalcException() : base("Nepravilno vvedeni dani!")
        {

        }
        public CalcException(string message) : base (message)
        {

        }
    }
    static public class Calculator
    {
        static private void CheckString(string str)
        {
            Regex reg = new Regex("^[0-9]+(-|/|\\*|\\+)[0-9]+$");
            if (!reg.IsMatch(str)) throw new CalcException();
        }

        static public void Calculation(string str)
        {
            int i;
            try
            {
                CheckString(str);
            }
            catch(CalcException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            for (i = 0; i < str.Length; i++)
                if (str[i] == '+' || str[i] == '-' || str[i] == '/' || str[i] == '*')
                    break;
            switch (str[i])
            {case '+':
                    Console.WriteLine(int.Parse(str.Substring(0, i)) + int.Parse(str.Substring(i + 1, str.Length - i - 1)));
                    break;
                case '-':
                    Console.WriteLine(int.Parse(str.Substring(0, i)) - int.Parse(str.Substring(i + 1, str.Length - i - 1)));
                    break;
                case '/':
                    try {
                    Console.WriteLine(int.Parse(str.Substring(0, i)) / int.Parse(str.Substring(i + 1, str.Length - i - 1)));
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine("Dilyty na nul ne mozhna!");                   
                    }
                    break;
                case '*':
                    Console.WriteLine(int.Parse(str.Substring(0, i)) * int.Parse(str.Substring(i + 1, str.Length - i - 1)));
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedit vyraz yakiy hochete obchyslyty:");
            string viraz = Console.ReadLine();
            Console.Write("Resultat:");

            Calculator.Calculation(viraz);
            Console.Read();
        }
    }
}
