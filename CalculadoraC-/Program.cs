using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");

            Calculadora calculadora = new Calculadora();

            
            Console.WriteLine("Digite a operação: ");
            string operacao = Console.ReadLine();
            switch (operacao)
                {

                    case "+":
                        calculadora.soma();
                        break;

                    case "-":
                        calculadora.subtracao();
                        break;

                    case "*":
                        calculadora.multiplicacao();
                        break;

                    case "/":
                        calculadora.divisao();
                        break;
                }
            Console.ReadKey(); 

        }
    }
}
       
