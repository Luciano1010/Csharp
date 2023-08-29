using System.Data;

namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> contas = new Queue<string>();
            int confirmar = 0;  
            bool parada = false;
            
           while (parada == false) 
            {
                Console.WriteLine(
                    "\n\n *******************************************************" +
                    "\n   *************************                              " +
                    "\n   * *  *****   *     *  * *     *Conta bancaria*         " +
                    "\n   * *    *   * * *   *  * *                              " +
                    "\n   * *    *  *     *  **** *                              " +
                    "\n   *************************                              " +
                    "\n                                                          " +
                    "\n              1 - Adicionar Cliente na fila               " +
                    "\n              2 - Listar todos os Clientes                " +
                    "\n              3 - Retirar Cliente da Fila                 " +
                    "\n              0 - Sair                                    " +
                    "\n **                                                   **  " +
                    "\n\n********************************************************" +
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
                            
                             Console.WriteLine(" Escreva o nome do cliente: ");
                        contas.Enqueue(Console.ReadLine());
                        Console.Clear();
                        break;
                            
                    case 2:

                    if (contas.Count() == 0) 
                            {
                                    Console.WriteLine(" a lista vazia ");    
                            }
                           
                    else 
                            {
                            Console.WriteLine("===============");
                            Console.WriteLine("fila atual");
                            foreach (var item in contas)
                            Console.WriteLine(item);
                            Console.WriteLine("===============");
                            }
                    break;
                           
                                    
                              case 3:
                     if (contas.Count() == 0)
                        {
                            Console.WriteLine(" Lista Vazia ");
                        }
                    else
                        {
                           contas.Dequeue();
                            
                        }
                    break;


                    default: Console.WriteLine(" Opção Invalida: ");
                            break;
                    
                    }
                    
            }
                         
                
        }

    }

}
           











        