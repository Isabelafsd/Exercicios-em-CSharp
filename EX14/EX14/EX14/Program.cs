using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EX14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercicio 14!");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            int n = 3, n2 = 4;
            uint[,] matriz = new uint[n, n2];
            int posLinha=0, posColuna=0;
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
            uint num=procuraMaior(matriz,ref posLinha,ref posColuna);
            Console.WriteLine("O maior elemento da matriz informada é " + num + " e sua posição é:[" + posLinha + "," + posColuna + "]");
            num= procuraMenor(matriz, ref posLinha, ref posColuna);
            Console.WriteLine("O menor elemento da matriz informada é " + num + " e sua posição é:[" + posLinha + "," + posColuna + "]");
            finalizaPrograma();
        }
        static uint procuraMaior(uint[,] matriz, ref int posl, ref int posc)
        {
            uint maior = uint.MinValue;
            for (int x = 0; x < matriz.GetLength(0); x++)
            {
                for (int y = 0; y < matriz.GetLength(1); y++)
                {
                    if (matriz[x, y] > maior)
                    {
                        maior = matriz[x, y];
                        posl = x;
                        posc = y;
                    }
                }
            }
            return maior;
        }
        static uint procuraMenor(uint[,] matriz, ref int posl, ref int posc)
        {
            uint menor = uint.MaxValue;
            for (int x = 0; x < matriz.GetLength(0); x++)
            {
                for (int y = 0; y < matriz.GetLength(1); y++)
                {
                    if (matriz[x, y] < menor)
                    {
                        menor = matriz[x, y];
                        posl = x;
                        posc = y;
                    }
                }
            }
            return menor;
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
