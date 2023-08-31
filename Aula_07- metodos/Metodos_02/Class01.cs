using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_02
{
    internal class Class01
    {
        public static void MetodoPublico() // é o metodo livre que posso usar em outras soluções
        {
            Console.WriteLine(" Metodo Publico - Classe 01");
        }

        internal static void Metodointernal() // funciona somente dentro do projeto
        {
            Console.WriteLine(" Metodo internal - Classe 01");
        }
        protected static void MetodoProtected() // so funciona se tiver uma herança
        {
            Console.WriteLine(" Metodo Protected - Classe 01");
        }
        private static void MetodoPrivado() // so funciona dentro da classe onde foi criado
        {
            Console.WriteLine(" Metodo Private - Classe 01");
        }


    }
}
