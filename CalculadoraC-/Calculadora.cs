using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraC_
{
    internal class Calculadora
    {
        public int soma()
        {
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 + num2;

            Console.WriteLine("Resultado: {0}", result);

            return result;
        }
        public int subtracao()
        {
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 - num2;

            Console.WriteLine("Resultado: {0}", result);

            return result;

        }
        public int multiplicacao()
        {
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 * num2;

            Console.WriteLine("Resultado: {0}", result);

            return result;
        }
        public double divisao()
        {
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            while (num1 == 0)
            {
                Console.WriteLine("Erro: não é possível dividir 0");
                return 0;
            }

            double result = num1 / num2;

            Console.WriteLine("Resultado: {0}", result);

            return result;

        }
    }
}

