using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DominioCalc;

namespace Test
{
    [TestClass]
    public class AritmeticaTest
    {
        [TestMethod]
        public void TestSumarNum1YNum2()
        {
            //Arrange
            AritmeticaBasica aritmetica = new AritmeticaBasica();
            int valorEsperado = 3;

            //Act
            var result = aritmetica.Sumar(1, 2);

            //Assert
            Assert.AreEqual(valorEsperado, result);
        }
        [TestMethod]
        public void TestRestarNum1YNum2()
        {
            //A
            AritmeticaBasica aritmetica = new AritmeticaBasica();
            int valorEsperado = 1;

            //A
            var result = aritmetica.Restar(2, 1);

            //A
            Assert.AreEqual(valorEsperado, result);


        }
        [TestMethod]
        public void TestMultiplicarNum1YNum2()
        {
            //A
            AritmeticaBasica aritmetica = new AritmeticaBasica();
            int valorEsperado = 4;

            //A
            var result = aritmetica.Multiplicar(2, 2);
            //A
            Assert.AreEqual(valorEsperado, result);
        }
        [TestMethod]
        public void TestDividirNum1YNum2()
        {
            //A
            AritmeticaBasica aritmetica = new AritmeticaBasica();
            int valorEsperado = 4;

            //A
            var result = aritmetica.Dividir(20, 5);
            //A
            Assert.AreEqual(valorEsperado, result);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivisionEntreCeroNum1YNum2()
        {
            //A
            AritmeticaBasica aritmetica = new AritmeticaBasica();
            int valorEsperado = 0;

            //A
            var result = aritmetica.Dividir(20, 0);
            //A
            Assert.AreEqual(valorEsperado, result);
        }
    }
}
