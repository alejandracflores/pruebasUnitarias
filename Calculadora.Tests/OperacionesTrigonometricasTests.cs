using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculadora;

namespace Calculadora.Tests
{
    [TestClass]
    public class OperacionesTrigonometricasTests
    {
        private const double Delta = 0.0001;

        [TestInitialize]
        public void Setup()
        {
            Console.WriteLine("Iniciando la ejecución de pruebas, espere...");
        }

        [TestMethod]
        [TestCategory("Trigonometría")]
        public void CalcularSeno_Angulo30_RetornaSin30()
        {
            // Arrange
            double angulo = 30;
            double expectedResult = 0.5; // sin(30°) = 0.5

            // Act
            double result = OperacionesTrigonometricas.CalcularSeno(angulo);

            // Assert
            Assert.AreEqual(expectedResult, result, Delta);
        }

        [TestMethod]
        [TestCategory("Trigonometría")]
        public void CalcularCoseno_Angulo60_RetornaCos60()
        {
            // Arrange
            double angulo = 60;
            double expectedResult = 0.5; // cos(60°) = 0.5

            // Act
            double result = OperacionesTrigonometricas.CalcularCoseno(angulo);

            // Assert
            Assert.AreEqual(expectedResult, result, Delta);
        }
    }
}