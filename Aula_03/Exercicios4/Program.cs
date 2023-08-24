using System.Runtime.Serialization;

namespace Exercicios4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorTotal = 0;
            int cachorroquente = 10;
            int x_salada = 15;
            int X_bacon = 18;
            int Bauru = 12;
            int refrigerante = 8;
            int suco_de_laranaja = 13;
            int opcao;
            int quantidade;

            Console.WriteLine("\n--- Cardapio do Dia ---\n ");
            
            Console.WriteLine(" Opção 1 para cachorro quente:R$ 10,00 ");
            Console.WriteLine(" Opção 2 para X-Salada:------>R$ 15,00 ");
            Console.WriteLine(" Opção 3 para X-Bacon:------->R$ 18,00 ");
            Console.WriteLine(" Opção 4 para Bauru:--------->R$ 12,00 ");
            Console.WriteLine(" Opção 5 para Refrigerante:-->R$ 8,00 ");
            Console.WriteLine(" Opção 6 para Suco de Laranja:R$ 13,00");


            Console.WriteLine("\n Escolha a opção desejada: ");
            opcao = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\n Escolha Quantidade: ");
            quantidade = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();
            switch (opcao) 
           
             {
                case 1:
                    Console.WriteLine(" Sua Escolha foi: Cachorro Quente  ");
                    valorTotal = cachorroquente * quantidade;
                    break;
                   
                    
                case 2:
                    Console.WriteLine(" Sua Escolha foi: X - Salada ");
                    valorTotal = x_salada * quantidade;
                    break;
                    
                  

                case 3:
                    Console.WriteLine(" Sua Escolha foi: X-Bacon ");
                    valorTotal = X_bacon * quantidade;
                    break;
                    
                case 4:
                    Console.WriteLine(" Sua Escolha foi: Bauru ");
                    valorTotal =  Bauru * quantidade;
                    break;
                    

                    

                    
                case 5:
                    Console.WriteLine(" Sua Escolha foi: Refrigerante ");
                    valorTotal = refrigerante * quantidade;
                    break;
                   

                case 6:
                    Console.WriteLine(" Sua Escolha foi: Suco de Laranja ");
                    valorTotal = suco_de_laranaja * quantidade;
                    break;
                    
                default:
                    Console.WriteLine(" Opção invalida ");
                    break;
                    

            }
                  
                  Console.WriteLine($"Valor :{valorTotal} \n --------------------------");

        }

    }
                
}

                  







                







            
            


      
            
            













