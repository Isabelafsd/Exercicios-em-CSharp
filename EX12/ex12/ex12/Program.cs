using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercicio 12!");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            int nalunos = 10, nquest = 8;
            int[] alunos = new int[nalunos];
            char[] gabarito = new char[nquest];
            int[] notas = new int[nalunos];
            for (int x = 0; x < gabarito.Length; x++)
            {
                try
                {
                    Console.Write("Gabarito da " + (x + 1) + "° questão(A,B,C ou D): ");
                    switch (char.Parse(Console.ReadLine().ToUpper()))
                    {
                        case 'A':
                            gabarito[x] = 'A';
                            break;
                        case 'B':
                            gabarito[x] = 'B';
                            break;
                        case 'C':
                            gabarito[x] = 'C';
                            break;
                        case 'D':
                            gabarito[x] = 'D';
                            break;
                        default:
                            throw new FormatException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Caracter inválido");
                    Console.WriteLine("Digite uma tecla para continuar");
                    Console.ReadKey();
                    x--;
                }
            }
            Console.Clear();
            for (int x = 0; x < alunos.Length; x++)
            {
                try
                {
                    Console.Write("Numero do " +(x + 1) + "° aluno: ");
                    alunos[x] = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Numero real inválido");
                    Console.WriteLine("Digite uma tecla para continuar");
                    Console.ReadKey();
                    x--;
                }
            }
            Console.Clear();
                confereRespostas(alunos,gabarito,notas);
                 mostraNotas(alunos, notas);
            Console.WriteLine("Porcentagem de alunos aprovados: " + (aprovacao(notas) / nalunos) *100+ "%");
            finalizaPrograma();

        }
        public static void confereRespostas(int[] alunos, char[] gabarito, int[] notas)
        {
            int nota = 0;
            for(int y=0; y<alunos.Length;y++)
            {
                for(int x=0;x<gabarito.Length;x++)
                {
                    try
                    {
                        Console.Write("Gabarito da " + (x + 1) + "° questão(A,B,C ou D) do aluno " + alunos[y]+": ");
                        switch (char.Parse(Console.ReadLine().ToUpper()))
                        {
                            case 'A':
                                if (gabarito[x] == 'A')
                                    nota++;
                                break;
                            case 'B':
                                if (gabarito[x] == 'B')
                                    nota++;
                                break;
                            case 'C':
                                if (gabarito[x] == 'C')
                                    nota++;
                                break;
                            case 'D':
                                if (gabarito[x] == 'D')
                                    nota++;
                                break;
                            default:
                                throw new FormatException();
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Caracter inválido");
                        Console.WriteLine("Digite uma tecla para continuar");
                        Console.ReadKey();
                        x--;
                    }
                }
                Console.Clear();
                notas[y] = nota;
                nota = 0;
            }
        }
        public static void mostraNotas(int[] alunos, int[] notas)
        {
            for (int y = 0; y < alunos.Length; y++)
            {
                Console.WriteLine("Nota " + (y + 1) + " do aluno " + alunos[y] + ": " + notas[y]);
            }
        }
        public static double aprovacao(int[] notas)
        {
            double aprovados = 0;
            for (int y = 0; y < notas.Length; y++)
            {
                if (notas[y] >= 5)
                    aprovados++;
            }
            return aprovados;
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
