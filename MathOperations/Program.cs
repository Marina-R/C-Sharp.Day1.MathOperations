using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        public string Add(int a, int b)
        {
            return (a+b).ToString();
        }
        public string Substract(int a, int b)
        {
            return (a-b).ToString();
        }
        public string Multiplicate(int a, int b)
        {
            return (a*b).ToString();
        }
        public string Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("You can not divide by zero. Please enter another number.");
            }
            else
            {
                return (a / b).ToString();
            }
            return String.Empty;
        }   
        static void Main(string[] args)
        {
            Program mathOperations = new Program();
            mathOperations.Add(3, 4);
            mathOperations.Divide(52, 2);
            mathOperations.Multiplicate(24, 9);
            mathOperations.Substract(2, 52);
        }
    }
}
