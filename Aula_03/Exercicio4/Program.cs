namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? palavra1, palavra2, palavra3;

            Console.WriteLine(" Digite a primeira palavra: ");
            palavra1 = Console.ReadLine();

            Console.WriteLine(" Digite a segunda palavra: ");
            palavra2 = Console.ReadLine();

            Console.WriteLine(" Digite a terceira palavra: ");
            palavra3 = Console.ReadLine();

            if( palavra1 is not null && palavra2 is not null && palavra3 is not null) 
            {   // Verificando se é vertebrado ou invertebrado
                if (palavra1.Equals("vertebrado")) 
                {  /* verificando se é ave ou mamimefero */
                   if(palavra2.Equals("ave")) 
                    {
                       if (palavra3.Equals(" carnivoro")) 
                        {
                            Console.WriteLine(" aguia ");
                        }

                        else 
                        {
                            Console.WriteLine("Pomba");
                        }
                    }
                }
                else 
                {
                    if (palavra1.Equals("invertebrado"))
                    {  /* verificando se é ave ou mamimefero */
                        if (palavra2.Equals("inseto"))
                        {
                            if (palavra3.Equals(" carnivoro"))
                            {
                                Console.WriteLine(" aguia ");
                            }

                            else
                            {
                                if (palavra3.Equals.("onivoro")) 
                                {
                                      Console.WriteLine("")
                                }
                                
                                    Console.WriteLine("Pomba");
                            }
                        }
            }
                else
            {
                Console.WriteLine(" As palavras não podem ser nulas");
            }


        
        
        
        
        
        
        
        }



    }
}