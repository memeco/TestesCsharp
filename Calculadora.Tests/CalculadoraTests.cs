using System;
using Xunit;
using Calculadora;
using CalculadoraSimples;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void SomarNumeros()
        {   
            // Arrange
            double num1 = 5;
            double num2 = 2;
            string operacao = "+";
            double esperado = 7;

            // Act
            double resultado = Program.Calcular(num1, num2, operacao);
            
            // Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void SubtrairNumeros()
        {   
            
            // Arrange
            double num1 = 5;
            double num2 = 2;
            string operacao = "-";
            double esperado = 3;
            
            // Act
            double resultado = Program.Calcular(num1, num2, operacao);
            
            // Assert
            Assert.Equal(esperado, resultado);
        }
        
        [Fact]
        public void MultiplicarNumeros()
        {   
            // arrange
            
            double num1 = 5;
            double num2 = 3;
            string operacao = "*";
            double esperado = 15;

            // Act
            double resultado = Program.Calcular(num1, num2, operacao);
            
            // Assert
            Assert.Equal(esperado, resultado);
            

        }
        [Fact]
        public void DividirNumeros()
        {
            double num1 = 10;
            double num2 = 2;
            string operacao = "/";
            double esperado = 5;

            double resultado = Program.Calcular(num1, num2, operacao);

            Assert.Equal(esperado, resultado);
        }
    }
}
