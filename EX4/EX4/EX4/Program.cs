using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4
{
    class Program
    {
        static void Main(string[] args)
        {
			    Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercício 4!");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
			    Console.ForegroundColor = ConsoleColor.White;
            int opcao;
            double num1 = 0, num2 = 0;
            bool erro = false, sair = false;
            while (!sair)
            {
                menu();
                try
                {
                    Console.Write("Opcão desejada:");
                    opcao = int.Parse(Console.ReadLine());
                    if (opcao > 2 || opcao < 1)
                        throw new FormatException();
                    else if (opcao == 1)
                    {
                        while (!erro)
                        {
                            Console.Write("Operando 1: ");
                            erro = double.TryParse(Console.ReadLine(), out num1);
                            if (!erro)
                                erroEntrada();
                            else
                            {
                                Console.Write("Operando 2: ");
                                erro = double.TryParse(Console.ReadLine(), out num2);
                                if (!erro)
                                    erroEntrada();
                            }
                        }
                        Console.WriteLine("O resultado da soma é: " + somaNumeros(num1, num2));
                    }
                    else
                    {
                        while (!erro)
                        {
                            Console.Write("Numero a ser calculado a raiz quadrada: ");
                            erro = double.TryParse(Console.ReadLine(), out num1);
                            if (!erro)
                                erroEntrada();
                        }
                        Console.WriteLine("A raiz quadrada de " + num1 + " é " + raizQuadrada(num1));
                    }
                    sair = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Você deve digitar uma opção válida(1 ou 2)");
                    Console.WriteLine("Digite uma tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            finalizaPrograma();
        }
        public static void menu()
        {
            Console.WriteLine("Menu de opçoēs:\n1-Soma de dois números\n2-Raiz quadrada" +
            " de um número");
            Console.WriteLine("------------------------------------------------------------------------------------------");
        }
        public static void erroEntrada()
        {
            Console.WriteLine("Numero inválido,digite uma tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }
        public static double somaNumeros(double n1, double n2)
        {
            return (n1 + n2);
        }
        public static double raizQuadrada(double num)
        {
            return Math.Sqrt(num);
        }
        public static void finalizaPrograma()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("Programa finalizado!");
            Console.WriteLine("Digite uma tecla para fechar.");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.ReadKey();

        }
    }
}
