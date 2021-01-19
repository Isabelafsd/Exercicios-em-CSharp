using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercicio 10!");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite 6 valores:");
            int n = 6, somapares = 0, nimpar = 0;
            int[] numeros = new int[n];
            for (int x = 0; x < numeros.Length; x++)
            {
                try
                {
                    Console.Write((x + 1) + "° valor: ");
                    numeros[x] = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Numero real inválido");
                    Console.WriteLine("Digite uma tecla para continuar");
                    Console.ReadKey();
                    x--;
                }
            }
            confereParImpar(numeros, ref somapares, ref nimpar);
            Console.WriteLine("A soma dos números pares digitados é:" + somapares);
            Console.WriteLine("A quantidade de números ímpares digitados é:" + nimpar);
            finalizaPrograma();
        }
        public static void confereParImpar(int [] numeros, ref int somapares, ref int nimpar)
        {
            for (int x = 0; x < numeros.Length; x++)
            {
                if (numeros[x] % 2 == 0)
                {
                    somapares += numeros[x];
                    Console.WriteLine("Número par digitado na posição " + x + " do vetor: " + numeros[x]);
                }
                else
                {
                    nimpar++;
                    Console.WriteLine("Número ímpar digitado na posição " + x + " do vetor: " + numeros[x]);
                }
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
