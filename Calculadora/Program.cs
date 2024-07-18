using System;

namespace CalculadoraSimples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação desejada (+, -, *, /):");
            string operacao = Console.ReadLine();

            double resultado = Calcular(num1, num2, operacao);

            Console.WriteLine($"O resultado de {num1} {operacao} {num2} é {resultado}.");
        }

        public static double Calcular(double num1, double num2, string operacao)
        {
            return operacao switch
            {
                "+" => num1 + num2,
                "-" => num1 - num2,
                "*" => num1 * num2,
                "/" => num1 / num2,
                _ => throw new ArgumentException("Operação inválida.")
            };
        }
    }
}
