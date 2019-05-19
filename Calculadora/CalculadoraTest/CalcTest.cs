using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculadora;




namespace CalculadoraTest
{
    [TestFixture]
    public class CalcTest
    {
        [Test]
        public void TestSumaPositivoPositivo()
        {
            //Arrange
            int a = 4;
            int b = 3;
            int resultadoEsperado = 7;
            int resultadoCalculado = 0;

            //Act
            resultadoCalculado = Calculadora.Calc.Suma(a, b);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoCalculado);
        }

        [Test]
        public void TestSumaPositivoNegativo()
        {
            //Arrange
            int a = 4;
            int b = -3;
            int resultadoEsperado = 1;
            int resultadoCalculado = 0;

            //Act
            resultadoCalculado = Calculadora.Calc.Suma(a, b);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoCalculado);
        }

        [Test]
        public void TestSumaNegativoNegativo()
        {
            //Arrange
            int a = -4;
            int b = -3;
            int resultadoEsperado = -7;
            int resultadoCalculado = 0;

            //Act
            resultadoCalculado = Calculadora.Calc.Suma(a, b);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoCalculado);
        }

        [Test]
        public void TestSumaConmutativa()
        {
            //Arrange
            int a = 4;
            int b = 2;
            int resultadoCalculado1 = 0;
            int resultadoCalculado2 = 0;

            //Act
            resultadoCalculado1 = Calculadora.Calc.Suma(a, b);
            resultadoCalculado2 = Calculadora.Calc.Suma(b, a);

            //Assert
            Assert.AreEqual(resultadoCalculado1, resultadoCalculado2);
        }

        [Test]
        public void TestRestaPositivoPositivo()
        {
            //Arrange
            int a = 4;
            int b = 3;
            int resultadoEsperado = 1;
            int resultadoCalculado = 0;

            //Act
            resultadoCalculado = Calculadora.Calc.Resta(a, b);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoCalculado);
        }

        [Test]
        public void TestRestaPositivoNegativo()
        {
            //Arrange
            int a = 4;
            int b = -3;
            int resultadoEsperado = 7;
            int resultadoCalculado = 0;

            //Act
            resultadoCalculado = Calculadora.Calc.Resta(a, b);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoCalculado);
        }

        [Test]
        public void TestRestaNoConmutativa()
        {
            //Arrange
            int a = 4;
            int b = 2;
            int resultadoCalculado1 = 0;
            int resultadoCalculado2 = 0;

            //Act
            resultadoCalculado1 = Calculadora.Calc.Resta(a, b);
            resultadoCalculado2 = Calculadora.Calc.Resta(b, a);

            //Assert
            if (a != b)
            {
                Assert.AreNotEqual(resultadoCalculado1, resultadoCalculado2);
            } else
            {
                Assert.AreEqual(resultadoCalculado1, resultadoCalculado2);
            }
        }

        [Test]
        public void TestMultiplicaPositivoPositivo()
        {
            //Arrange
            int a = 4;
            int b = 3;
            int resultadoEsperado = 12;
            int resultadoCalculado = 0;

            //Act
            resultadoCalculado = Calculadora.Calc.Multiplicacion(a, b);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoCalculado);
        }

        [Test]
        public void TestMultiplicaPositivoNegativo()
        {
            //Arrange
            int a = 4;
            int b = -3;
            int resultadoEsperado = -12;
            int resultadoCalculado = 0;

            //Act
            resultadoCalculado = Calculadora.Calc.Multiplicacion(a, b);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoCalculado);
        }

        [Test]
        public void TestMultiplicaNegativoNegativo()
        {
            //Arrange
            int a = -4;
            int b = -3;
            int resultadoEsperado = 12;
            int resultadoCalculado = 0;

            //Act
            resultadoCalculado = Calculadora.Calc.Multiplicacion(a, b);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoCalculado);
        }

        [Test]
        public void TestMultiplicaConmutativa()
        {
            //Arrange
            int a = 4;
            int b = 2;
            int resultadoCalculado1 = 0;
            int resultadoCalculado2 = 0;

            //Act
            resultadoCalculado1 = Calculadora.Calc.Multiplicacion(a, b);
            resultadoCalculado2 = Calculadora.Calc.Multiplicacion(b, a);

            //Assert
            Assert.AreEqual(resultadoCalculado1, resultadoCalculado2);
        }

        [Test]
        public void TestMultiplicaPorCero()
        {
            //Arrange
            int a = 0;
            int b = 6;
            int resultadoEsperado = 0;
            int resultadoCalculado;

            //Act
            resultadoCalculado = Calculadora.Calc.Multiplicacion(a, b);

            //Assert
            if ((a == 0)|| (b == 0)){
                Assert.AreEqual(0, resultadoCalculado);
            }
        }

        [Test]
        public void TestDivision()
        {
            //Arrange
            float a = 4;
            float b = 2;
            float resultadoEsperado = 2;
            float resultadoCalculado = 0;

            //Act
            resultadoCalculado = Calculadora.Calc.Divide(a, b);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoCalculado);
        }

        [Test]
        public void TestDivision2()
        {
            //Arrange
            float a = 2;
            float b = 4;
            float resultadoCalculado = 0;

            //Act
            resultadoCalculado = Calculadora.Calc.Divide(a, b);

            //Assert
            if (b > a)
            {
                Assert.Less(0, resultadoCalculado);
                Assert.Greater(1, resultadoCalculado);
            }
            
        }

        [Test]
        public void TestDivisionNoConmutativa()
        {
            //Arrange
            float a = 4;
            float b = 2;
            float resultadoCalculado1 = 0;
            float resultadoCalculado2 = 0;

            //Act
            resultadoCalculado1 = Calculadora.Calc.Divide(a, b);
            resultadoCalculado2 = Calculadora.Calc.Divide(b, a);

            //Assert
            if (a != b)
            {
                Assert.AreNotEqual(resultadoCalculado1, resultadoCalculado2);
            }
            else
            {
                Assert.AreEqual(resultadoCalculado1, resultadoCalculado2);
            }
        }

        [Test]
        public void TestDivisionPorCero()
        {
            //Arrange
            float a = 4;
            float b = 0;
            float resultadoEsperado = -1;
            float resultadoCalculado = 0;

            //Act
            resultadoCalculado = Calculadora.Calc.Divide(a, b);

            //Assert
            if (b == 0)
            {
                Assert.AreEqual(-1, resultadoCalculado);
            }
        }
    }
}
