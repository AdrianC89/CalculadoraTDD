using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calc
    {
        static void Main(string[] args)
        {
        }

        public static int Suma(int a, int b)
        {
            return a+b;
        }

        public static int Resta(int a, int b)
        {
            return a-b;
        }

        public static int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        public static float Divide(float a, float b)
        {
            if (b == 0)
            {
                return -1;
            } 
            return a/b;
        }

        public static float Sqrt(float valor)
        {
            return 0;
        }
    }
}
