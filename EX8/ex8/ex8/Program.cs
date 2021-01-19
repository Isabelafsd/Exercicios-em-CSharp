using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercicio 8!");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            int N;
            int[] vetor=new int[0];
            bool sair = false;
            while (!sair)
            {
                try
                {
                    Console.Write("Quantidade de valores a serem lidos: ");
                    N = int.Parse(Console.ReadLine());
                    vetor = new int[N];
                    for(int x = 0; x < N; x++)
                    {
                        try
                        {
                            Console.Write((x + 1) + "° valor: ");
                            vetor[x] = int.Parse(Console.ReadLine());
                            if (vetor[x] <= 0)
                                throw new FormatException();
                        }
                        catch(FormatException)
                        {
                            Console.WriteLine("Digite um valor numérico inteiro positivo");
                            Console.WriteLine("Pressione qualquer tecla para continuar");
                            Console.ReadKey();
                            x--;
                        }
                    }
                    sair = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Digite um valor numérico inteiro");
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                }
            }
            fatorial(vetor);
            finalizaPrograma();
        }
        public static void fatorial(int [] vetor)
        {
            Console.WriteLine("");
            Console.WriteLine("Resultado dos fatoriais:");
            int fatorial;
            int cont = 0;
            while (cont < vetor.Length)
            {
                fatorial = 1;
                for (int n = 1; n <= vetor[cont]; n++)
                {
                    fatorial *= n;
                }
                Console.WriteLine(vetor[cont] + "!= " + fatorial);
                cont++;
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
