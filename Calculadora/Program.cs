using System;

namespace Calculadora
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            string input1 = Console.ReadLine();
            Console.Write("Digite o segundo número: ");
            string input2 = Console.ReadLine();
            Console.Write("Digite a operação (+, -, *, /): ");
            string operacao = Console.ReadLine();

            try
            {
                double resultado = Calcular(input1, input2, operacao);
                Console.WriteLine($"O resultado de {input1} {operacao} {input2} é {resultado}.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Erro de formato: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Erro de divisão por zero: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }

        public static double Calcular(string a, string b, string operacao)
        {
            if (!double.TryParse(a, out double numero1) || !double.TryParse(b, out double numero2))
            {
                throw new FormatException("Entrada inválida. Por favor, insira números válidos.");
            }

            return operacao switch
            {
                "+" => Somar(numero1, numero2),
                "-" => Subtrair(numero1, numero2),
                "*" => Multiplicar(numero1, numero2),
                "/" => Dividir(numero1, numero2),
                _ => throw new ArgumentException("Operação inválida. Use +, -, * ou /."),
            };
        }

        public static double Somar(double a, double b) => a + b;

        public static double Subtrair(double a, double b) => a - b;

        public static double Multiplicar(double a, double b) => a * b;

        public static double Dividir(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException("Não é possível dividir por zero.");
            return a / b;
        }
    }
}
