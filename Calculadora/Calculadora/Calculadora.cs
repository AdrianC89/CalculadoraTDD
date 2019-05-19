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
            float valor = 120;
            float resultadoEsperado = 10.9544511F;
            float resultadoCalculado;

            //Act
            resultadoCalculado = Calculadora.Calc.Sqrt(valor);
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

        public static float Sqrt(float x)
        {
            //Raiz cuadrada a partir de la aproximación de Bakhshali
            float n;
            bool encontrado= false;
            float mejorValor = 0;
            float mejorDiferencia = 999999;
            float diferencia = 999999;
            while (!encontrado)
            {
                for(int i = 0; i < x; i++)
                {
                    diferencia = x - i * i;
                    if (diferencia < 0)
                    {
                        diferencia *= -1;
                    }
                    if(diferencia < mejorDiferencia)
                    {
                        mejorValor = i;
                        mejorDiferencia = diferencia;
                    }

                    if(diferencia > mejorDiferencia)
                    {
                        encontrado = true;
                        break;
                    }
                }
            }
            n = mejorValor;

            //no utilizamos las fuciones de calculadora porque resultaría una fórmula muy compleja de llamadas anidadas, menos intuitiva visualmente
            float r = (n * n * n * n + 6 * n * n * x + x * x) / (4 * n * n * n + 4 * n * x);
            Console.WriteLine(r);
            return r;
        }
    }
}
