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
            int resultadoCalculado1 = 1;
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
    }
}
