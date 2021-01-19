using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("Exercicio 9!");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            bool sair=false;
            double[] numeros = new double[3];
            double[] pesos = new double[3];
            byte opcao, cont = 0;
            while(!sair)
            {
                try
                {
                    menu();
                    Console.Write("Opção desejada: ");
                    opcao = byte.Parse(Console.ReadLine());
                    if (opcao < 1 || opcao > 4)
                        throw new FormatException();
                    while (cont < 3 && opcao!=4) 
                    {
                        try
                        {
                            Console.Write((cont+1) + "° valor: ");
                            numeros[cont] = double.Parse(Console.ReadLine());
                            cont++;
                        }
                        catch(FormatException)
                        {
                            Console.WriteLine("Numero real inválido");
                            Console.WriteLine("Digite uma tecla para continuar");
                            Console.ReadKey();
                        }
                    }
                    if (opcao == 1)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("O valor da média aritmética entre os valores " + numeros[0] + "," + numeros[1] + "," + numeros[2] + " é " + mediaArit(numeros));
                    }
                    else
                    {
                        cont = 0;
                        while (cont < 3 && opcao != 4)
                        {
                            try
                            {
                                Console.Write("Peso para o " + (cont + 1) + "° valor: ");
                                pesos[cont] = double.Parse(Console.ReadLine());
                                cont++;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Numero real inválido");
                                Console.WriteLine("Digite uma tecla para continuar");
                                Console.ReadKey();
                            }
                        }
                    }
                    if (opcao == 2)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("O valor da média ponderada entre os valores " + numeros[0] + "," + numeros[1] + "," + numeros[2] + " com pesos respectivos de " +
                            pesos[0] + "," + pesos[1] + "," + pesos[2] + " é " + mediaPond(numeros, pesos));
                    }
                    else if (opcao == 3)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("O valor da média aritmética entre os valores " + numeros[0] + "," + numeros[1] + "," + numeros[2] + " é " + mediaArit(numeros));
                        Console.WriteLine("O valor da média ponderada entre os valores " + numeros[0] + "," + numeros[1] + "," + numeros[2] + " com pesos respectivos de " +
                        pesos[0] + "," + pesos[1] + "," + pesos[2] + " é " + mediaPond(numeros, pesos));
                    }
                    else if (opcao == 4)
                        sair = true;
                        cont = 0;
                        Console.WriteLine("Digite uma tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                }
                catch(FormatException)
                {
                    Console.WriteLine("Opção inválida,digite um valor entre 1 e 4");
                    Console.WriteLine("Digite uma tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            finalizaPrograma();

        }
        
        
        public static void menu()
        {
            Console.WriteLine("Menu de opçoēs:\n1-Media Aritmética\n2-Media Ponderada" +
            "\n3-Media Aritmética e Média Ponderada\n4-Sair");
            Console.WriteLine("------------------------------------------------------------------------------------------");
        }
        public static double mediaArit(double [] num)
        {
            double soma = 0;
            for(int x=0;x<num.Length;x++)
            {
                soma += num[x];
            }
            return (soma / num.Length);
        }
        public static double mediaPond(double[] num,double [] pesos)
        {
            double somaPeso=0, somaNum=0;
            for (int x = 0; x < num.Length; x++)
            {
                somaPeso += pesos[x];
                somaNum += pesos[x] * num[x];
            }
            return (somaNum / somaPeso);
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
