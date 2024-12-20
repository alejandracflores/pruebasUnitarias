using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculadora;

namespace Calculadora.Tests
{
    [TestClass]
    public class OperacionesCombinatoriasTests
    {

        [TestInitialize]
        public void Setup()
        {
            Console.WriteLine("Iniciando la ejecución de pruebas, espere...");
        }

        [TestMethod]
        [TestCategory("Combinatoria")]
        public void CalcularFactorial_Numero5_Retorna120()
        {
            // Arrange
            int numero = 5;
            int expectedResult = 120;

            // Act
            int result = OperacionesCombinatorias.CalcularFactorial(numero);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [TestCategory("Combinatoria")]
        [ExpectedException(typeof(ArgumentException))]
        public void CalcularFactorial_NumeroNegativo_LanzaArgumentException()
        {
            // Arrange
            int numero = -1;

            // Act
            OperacionesCombinatorias.CalcularFactorial(numero);

            // Assert se maneja con ExpectedException
        }

        [TestMethod]
        [TestCategory("Combinatoria")]
        public void CalcularCombinaciones_5Elementos2Seleccionados_Retorna10()
        {
            // Arrange
            int n = 5;
            int k = 2;
            int expectedResult = 10;

            // Act
            int result = OperacionesCombinatorias.CalcularCombinaciones(n, k);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}