using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercicio 11!");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite 15 caracteres:");
            int n = 15;
            char[] A = new char[n];
            char[] B = new char[n];
            for (int x=0;x<A.Length;x++)
            {
                try
                {
                    Console.Write((x + 1) + "° caracter: ");
                    A[x] = char.Parse(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("Caracter inválido");
                    Console.WriteLine("Digite uma tecla para continuar");
                    Console.ReadKey();
                    x--;
                }
            }
            invertevetores(A, B);
            imprimevetores(A, B);
            finalizaPrograma();
        }
        public static void invertevetores(char[] A, char[] B)
        {
            for (int x = 0; x < A.Length; x++)
            {
                B[x] = A[(A.Length-1)- x ];
            }
        }
        public static void imprimevetores(char[] A, char[] B)
        {
            for (int x = 0; x < A.Length; x++)
            {
                Console.WriteLine("Posição " + x + " do vetor A: " + A[x]);
            }
            Console.WriteLine("");
            for (int x = 0; x < B.Length; x++)
            {
                Console.WriteLine("Posição " + x + " do vetor B: " + B[x]);
            }
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
