using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
			    Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercicio 7!");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
			    Console.ForegroundColor = ConsoleColor.White;
            int altavelocidade=0;
            int cont=1;
            float velocidade;
            bool sair = false;
            int velMaxima = 60;
            while(cont<=5)
            {
                while (!sair)
                {
                    try
                    {
                        Console.Write("Velocidade em Km/h do " + cont + "° carro: ");
                        velocidade = float.Parse(Console.ReadLine());
                        altavelocidade += ConfereVelocidade(velocidade,velMaxima);
                        sair = true;
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Valor inválido para a velocidade");
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        Console.WriteLine("");
                    }
               }
                cont++;
                sair = false;
            }
            Console.WriteLine("");
            Console.WriteLine(altavelocidade + " carros passaram do limite de velocidade de " + velMaxima + " Km/h");
            Console.WriteLine("O total arrecadado com multas foi de R$" + Multas(altavelocidade));
            finalizaPrograma();
        }
        public static int Multas(int numcarros)
        {
            return (150 * numcarros);
        }
        public static byte ConfereVelocidade(float veloc,int velMaxima)
        {
            byte altavelocidade = 0;
            if (veloc > velMaxima)
            {
                altavelocidade++;
                return altavelocidade;
            }
            else
                return altavelocidade;
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
