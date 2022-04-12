using System;

namespace ProjetoNumeroInteiro1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroInteiro;
            int i;

            Console.Write("INFORME UM NÚMERO INTEIRO: ");
            numeroInteiro = int.Parse(Console.ReadLine());

            if(1 <= numeroInteiro && numeroInteiro <= 1000)
            {
                Console.WriteLine("NÚMERO VÁLIDO!");

                i = 1;
                Console.WriteLine("\n os números inteiros ímpares entre 1 e " + numeroInteiro + " são:");
                while (i <= numeroInteiro)
                {
                    if (i%2 != 0)
                    {
                        Console.WriteLine("\t" + i);
                    }
                    i++;
                }
            }
            else
            {
                Console.WriteLine("\nNÚMERO INVÁLIDO!");
            }
            Console.WriteLine("\n\nPRESSIONE QUALQUER TECLA PARA ENCERRAR O PROGRAMA.");
            Console.ReadKey();
        }
    }
}
