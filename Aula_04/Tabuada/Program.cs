﻿using System.Diagnostics;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;// quando colocamos uma variavel no inicio ela é sempre lembrada//

            Console.WriteLine(" Digite a Tabuada: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for(int contador  = 1; contador <= 10;  contador++) 
            {
                Console.WriteLine($" {numero} x {contador} = {numero * contador}");
            }
        }
    }
}