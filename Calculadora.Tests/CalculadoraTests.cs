using System;
using Xunit;
using Calculadora;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        [Fact] // divisão por zero
        public void Calcular_DeveLancarDivideByZeroExceptionParaDivisaoPorZero()
        {
            // Arrange
            string input1 = "10";
            string input2 = "0";
            string operacao = "/";

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => Program.Calcular(input1, input2, operacao));
        }
    }
}
