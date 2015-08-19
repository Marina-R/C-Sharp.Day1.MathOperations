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
            //I know there is a mistake but can not think about the way to solve it right now whithout looking on the internet for help :)
        }   
        static void Main(string[] args)
        {
            
        }
    }
}
