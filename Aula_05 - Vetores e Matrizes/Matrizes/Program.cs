using System.Runtime.CompilerServices;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Coluna esta entre {} e as linhas estao em { 1,2,3} nesse caso sao 3 linhas  
            int[,] matriz01 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] matriz02 = new int[4, 4];

            int[,] matriz03 = { { 1, 2, 3 }, { 4, 5, 6 } };

            int[] vetor = { 1, 2, 3, 4 };

            // laço for na matriz 
            for(int indicelinha = 0; indicelinha < Math.Sqrt(matriz01.Length); indicelinha++)
               {
                       for(int indicecoluna = 0; indicecoluna < Math.Sqrt(matriz01.Length); indicelinha++) 
                   {
                       Console.WriteLine($" matriz01[{indicelinha},{indicecoluna}] = {matriz01[indicelinha,indicecoluna]}");
                   }
               } 


            /*for (int indicelinha = 0; indicelinha < Math.Sqrt(matriz01.Length); indicelinha++)
            {
                for (int indicecoluna = 0; indicecoluna < matriz01.Length; indicelinha++)
                {
                    Console.WriteLine($" matriz01[{indicelinha},{indicecoluna}] = {matriz01[indicelinha, indicecoluna]}");
                }
            }*/

            // modo de percorrer uma matriz inregular
            /*
            for (int indicelinha = 0; indicelinha < matriz03.GetLength(0); indicelinha++)
            {
                for (int indicecoluna = 0; indicecoluna < matriz03.GetLength(1); indicecoluna++)
                {
                    Console.WriteLine($" matriz03[{indicelinha},{indicecoluna}] = {matriz01[indicelinha, indicecoluna]}");
                }
            }*/
            // laço foreach, o elemento ele processa o que dentro do indice
            
                /*foreach (int elemento in vetor)
            {
                Console.Write(elemento);

            }*/

        }
    }

    }