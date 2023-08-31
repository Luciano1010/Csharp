namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> livros = new Stack<string>();
            int confirmar = 0;
            bool parada = false;

            while (parada == false)
            {   
                Console.WriteLine(
                    "\n\n **************************************************" +
                    "\n                                                     " +
                    "\n                 Biblioteca On-Line                  " +
                    "\n                                                     " +
                    "\n                                                     " +
                    "\n             1 - Adicione o Livro                    " +
                    "\n             2 - Listar todos os Livros              " +
                    "\n             3 - Retirar Livro da Pilha              " +
                    "\n             0 - Sair                                " +
                    "\n                                                     " +
                    "\n                                                     " +
                    "\n\n***************************************************" +
                    "");

                Console.WriteLine(" Digite a Opção desejada: ");
                confirmar = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (confirmar)
                {
                    case 0:
                        parada = true;
                        Console.WriteLine(" Operação Finalizada");
                        break;

                    case 1:

                        Console.WriteLine(" Escreva o nome dos livros ");
                        livros.Push(Console.ReadLine());
                        Console.WriteLine(" Livro Adicionado com sucesso");
                        Console.Clear();
                        break;

                    case 2:

                        if (livros.Count() == 0)
                        {
                            Console.WriteLine(" A Lista esta Vazia ");
                        }

                        else
                        {
                            Console.WriteLine("\n\n===============\n\n");
                            Console.WriteLine("* A pilha atual *");
                            foreach (var item in livros)
                                Console.WriteLine(item);
                           Console.WriteLine("\n\n===============\n\n");
                           
                       
                        }
                        break;


                    case 3:
                        if (livros.Count() == 0)
                        {
                            Console.WriteLine(" A Pilha esta Vazia ");
                            Console.Clear ();
                        }   
                        else
                        {
                            livros.Pop();
                            Console.WriteLine(" Livro Retirado com Sucesso: ");
                            Console.Clear();
                        }
                        break;


                    default:
                        Console.WriteLine(" Opção Invalida: ");
                        break;

                }

            }

        }
    }
}