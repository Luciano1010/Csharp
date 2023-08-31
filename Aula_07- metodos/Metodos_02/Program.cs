using Metodos_02.Namespace01;

namespace Metodos_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MetodoPublico();
            MetodoPrivado();
            Metodointernal();
            MetodoProtected();
           
        
            Class01.Metodointernal();
            Class01.MetodoPublico();
         ///  Class01.MetodoProtected();
         //   Class01.MetodoPrivado();

            Class02cs.MetodoPublico();
            Class02cs.Metodointernal();
          //  Class01.MetodoProtected();
          //  Class01.MetodoPrivado();
        }
   
        public static void MetodoPublico() 
        {
            Console.WriteLine(" Metodo Publico - Classe program");
        }

        internal static void Metodointernal()
        {
            Console.WriteLine(" Metodo internal - Classe program");
        }
        protected static void MetodoProtected()
        {
            Console.WriteLine(" Metodo Protected - Classe program");
        }
        private static void MetodoPrivado()
        {
            Console.WriteLine(" Metodo Private - Classe program");
        }





    }