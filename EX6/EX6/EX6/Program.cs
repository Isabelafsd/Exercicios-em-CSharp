using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX6
{
    class Program
    {
        static void Main(string[] args)
        {
			    Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercício 6!");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
			    Console.ForegroundColor = ConsoleColor.White;
            int soma=0;
            byte cont = 1;
            bool sair = false;
            while (cont < 3)
            {
                while (!sair)
                {
                    try
                    {
                        Console.Write(cont + "° valor inteiro: ");
                        soma += int.Parse(Console.ReadLine());
                        sair = true;
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("O valor digitado não é inteiro");
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                sair = false;
                cont++;
            }
            if (confereParImpar(soma))
                Console.WriteLine("A soma dos numeros digitados é " + soma + " e esse valor é par");
            else
                Console.WriteLine("A soma dos numeros digitados é " + soma + " e esse valor é ímpar");
            finalizaPrograma();

        }
        public static bool confereParImpar(int soma)
        {
            if (soma % 2 == 0)
                return true;
            else
                return false;
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
