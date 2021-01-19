using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercicio 13!");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            int n = 3;
            uint[,] matriz = new uint[n, n];
            for (int x = 0; x < matriz.GetLength(0); x++)
            {
                for (int y = 0; y < matriz.GetLength(1); y++)
                {
                    try
                    {
                        Console.Write("Elemento (" + x + "," + y + ") da matriz: ");
                        matriz[x, y] = uint.Parse(Console.ReadLine());
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Numero inválido, digite um numero inteiro positivo");
                        Console.WriteLine("Digite uma tecla para continuar");
                        Console.ReadKey();
                        y--;
                    }
					  catch(FormatException)
                    {
                        Console.WriteLine("Digite um numero inteiro positivo");
                        Console.WriteLine("Digite uma tecla para continuar");
                        Console.ReadKey();
                        y--;
                    }
                }
            }
            Console.WriteLine("A média dos elementos da diagonal principal da matriz informada é:" + mediaPrincipal(matriz));
            finalizaPrograma();
        }
        static double mediaPrincipal(uint[,] matriz)
        {
            uint soma = 0;
            for (int x = 0; x < matriz.GetLength(0); x++)
            {
                for (int y = 0; y < matriz.GetLength(1); y++)
                {
                    if (x == y)
                        soma += matriz[x, y];
                }
            }
            double media = (double)soma / matriz.GetLength(0);
            return media;
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
