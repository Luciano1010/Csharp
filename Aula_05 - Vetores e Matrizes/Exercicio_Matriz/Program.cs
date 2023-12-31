﻿using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Exercicio_Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0, resul = 0;
            int[] vetorMedia = new int[4];
            int[,] matrizInteiros = new int[4, 10];

                                           // get significa que estou pegando a coluna(1)
            for (int coluna = 0; coluna < matrizInteiros.GetLength(1); coluna++)
            {
                soma = 0;                  // get significa que estou pegando a coluna(1)
                for (int linha = 0; linha < matrizInteiros.GetLength(0); linha++)
                {

                    Console.WriteLine(
                        $"Digite um valor para a posição [{linha}, {coluna}]: ");
                    // gravar o numero na linha e coluna atual q estou.
                    matrizInteiros[linha, coluna] = Convert.ToInt32(Console.ReadLine());
                    soma += matrizInteiros[linha, coluna];
                }   // estou atribundo um novo valor ao soma- q seria soma + matriz
                vetorMedia[coluna] = soma / matrizInteiros.GetLength(0); 
                Console.WriteLine($"Soma de todos os elementos da coluna ({coluna + 1}) é: {vetorMedia[coluna]}\n\n");
                vetorMedia[coluna] = 0;                               //
            }


        }

    }

}




