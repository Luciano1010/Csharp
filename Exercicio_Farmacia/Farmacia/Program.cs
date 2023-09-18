using Farmacia.Controller;
using Farmacia.Model;
using System;


namespace Farmacia
{
    public class Program
    {


        private static ConsoleKeyInfo consoleKeyInfo;

        static void Main(string[] args)
        {

            int opcao = 0; // swhit case

            string nome, generico, fragancia = null; // nome dos produtos

            decimal preco;
            int tipo;
            int id;


            FarmaController produto = new();


            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("*********************************************");
                Console.WriteLine("                                             ");
                Console.WriteLine("===============FARMACIA DO POVO==============");
                Console.WriteLine("                SEJA BEM VINDO               ");
                Console.WriteLine("                                             ");
                Console.WriteLine("            1 - CRIAR PRODUTO                ");
                Console.WriteLine("            2 - LISTAR PRODUTOS              ");
                Console.WriteLine("            3 - ATUALIZAR PRODUTO            ");
                Console.WriteLine("            4 - DELETAR PRODUTO              ");
                Console.WriteLine("            5 - SAIR                         ");
                Console.WriteLine("                                             ");
                Console.WriteLine(" DIGITE A OPÇÃO DESEJADA:                    ");
                Console.WriteLine("                                             ");
                Console.WriteLine("*********************************************");
                try
                {

                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 10)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Magenta;

                        Sobre();
                        Console.ResetColor();
                        System.Environment.Exit(0);


                    }

                    switch (opcao)
                    {
                        case 1:
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("========================");
                            Console.WriteLine("*Crie o Produto desejado*\n");


                            {
                                Console.Write("\nDigite 1 para Medicamento e 2 para Cosmetico: \n");
                                tipo = Convert.ToInt32(Console.ReadLine());


                                Console.Write("Digite o Nome...: \n");
                                nome = Console.ReadLine();


                                Console.Write("Digite o valor do Produto R$ \n");
                                preco = Convert.ToDecimal(Console.ReadLine());

                                switch (tipo)
                                {
                                    case 1:
                                        Console.WriteLine("O Produto é Generico?:  ");
                                        generico = Console.ReadLine();
                                        Medicamento l1 = new Medicamento(produto.Gerarid(), nome, tipo, preco, generico);
                                        produto.Cadastrar(l1);
                                        break;


                                    case 2:
                                        Console.WriteLine("È perfume ou Cosmeticos? : ");
                                        fragancia = Console.ReadLine();
                                        Cosmetico c1 = new Cosmetico(produto.Gerarid(), nome, tipo, preco, fragancia);
                                        produto.Cadastrar(c1);
                                        break;


                                }


                                Console.WriteLine("Produto Criado com Sucesso");
                                Console.ResetColor();
                            }

                            KeyPress();
                            Console.Clear();
                            break;


                        case 2:

                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("*************************");
                            Console.WriteLine("     LISTA DE PRODUTOS   ");
                            Console.ResetColor();

                            produto.ListarTodososProdutos();

                            break;


                        case 3:
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("===================");
                            Console.WriteLine(" *Atualizar Produto* ");
                            Console.WriteLine("========================");


                            Console.Write("Digite o Id do Medicamento ou Cosmético: ");
                            id = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Digite o tipo Produto: ");
                            tipo = Convert.ToInt32(Console.ReadLine());


                            Console.Write(" Digite o nome do Produto: ");
                            nome = Console.ReadLine();


                            Console.WriteLine("Digite o valor do Produto");
                            preco = Convert.ToDecimal(Console.ReadLine());


                         
                            


                            switch (tipo)
                            {
                                case 1:
                                    Console.WriteLine("New Medicamento: ");
                                    generico = Console.ReadLine();
                                    Medicamento l1 = new Medicamento(id, nome, tipo, preco, generico);
                                    produto.AtualizarProduto(l1);
                                    break;


                                case 2:
                                    Console.WriteLine("New Comestico: ");
                                    fragancia = Console.ReadLine();
                                    Cosmetico c1 = new Cosmetico(id, nome, tipo, preco, fragancia);
                                    produto.Cadastrar(c1);
                                    break;


                            }
    ;
                            Console.ResetColor();
                            KeyPress();
                            Console.Clear();
                            break;



                        case 4: // primeiro preciso listar o produto aqui antes de deletar
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" *Deletar Produto* ");
                            produto.ListarTodososProdutos();

                            Console.WriteLine(" Digite o numero de indentificação do Produto");
                            id = Convert.ToInt32(Console.ReadLine());

                            produto.DeletarProduto(id);

                            Console.ResetColor();
                            KeyPress();
                            Console.Clear();
                            break;

                        case 5:
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("***************************************");
                            Console.WriteLine("FARMACIA DO POVO - FINALIZADO A SESSÃO ");
                            Console.WriteLine("***************************************");
                            Console.ResetColor();
                            KeyPress();
                            Console.Clear();
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nOpção Invalida");
                            Console.ResetColor();
                            KeyPress();
                            Console.Clear();
                            break;
                    }


                }
                catch (FormatException)
                {
                    Console.WriteLine("Digite Informações Validas");
                    
                }
                KeyPress();
                Console.Clear();

            }
            static void Sobre()

            {
                Console.WriteLine("\n***************************************************");
                Console.Write("\nFARMACIA DO POVO AGRADEÇA - SEMPRE PENSANDO EM VOCE");
                Console.WriteLine("\nProjeto Desenvolvido por - Luciano Simões ");
                Console.WriteLine("Email - luciano_lopesdealmeida@hotmail.com");
                Console.WriteLine("github.com/Luciano1010");
                Console.WriteLine("***************************************************");
            }
            static void KeyPress()

            {
                do
                {
                    Console.Write("\nPressione Enter para Continuar...");
                    consoleKeyInfo = Console.ReadKey();
                } while (consoleKeyInfo.Key != ConsoleKey.Enter);
            }
        }
    }
}
                        

                       


                       



                        








                        

                      


               

               
                







    
        


        


