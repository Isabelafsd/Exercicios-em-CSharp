using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
			    Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercicio 3!");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
			    Console.ForegroundColor = ConsoleColor.White;
            bool sair = false;
            double salario;
            while (!sair)
            {
                Console.Write("Digite o valor do salario: ");
                try
                {
                    salario = double.Parse(Console.ReadLine());
                    if (salario < 0)
                        throw new FormatException();
                    Console.WriteLine(AumentoSalario(salario));
                    sair = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Salario invalido,digite uma tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            finalizaPrograma();
        }

        public static string AumentoSalario(double salario)
        {
            double aumento;
            int percent;
            if (salario <= 1200)
            {
                percent = 10;
                aumento = (percent * salario) / 100;
                return "O salário antigo era de R$" + salario + " e deverar ter um aumento de R$" + aumento
                + "(" + percent + "%).O novo salario será de R$" + (salario + aumento);
            }
            else
            {
                percent = 5;
                aumento = (percent * salario) / 100;
                return "O salário antigo era de R$" + salario + " e deverar ter um aumento de R$" + aumento
                + "(" + percent + "%).O novo salario será de R$" + (salario + aumento);
            }
        }
        public static void finalizaPrograma()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("Programa finalizado!");
            Console.WriteLine("Digite uma tecla para continuar");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.ReadKey();
        }

    }
}
