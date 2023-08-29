namespace Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {   // ignora elementos repetidos
            HashSet<string> setnomes = new HashSet<string>()
            {
                "Luciano",
                "Robson",
                "Ingrid",
                "Ivone",
                "Luciano",
                "Ivone",
            };

            foreach(var nome in setnomes) 
            {
            
                Console.WriteLine(nome);    
            }
            Console.WriteLine();
            
            setnomes.Add("Bruno");
            setnomes.Add(null);
            setnomes.Add("M.S");

            foreach (var nome in setnomes)
            {

                Console.WriteLine(nome);
            }
            Console.WriteLine("===================") ;
            Console.WriteLine(" o nome Luciano existe: " + setnomes.Contains("Luciano"));
            Console.WriteLine("===================");
            
            setnomes.Remove("Luciano");
            foreach (var nome in setnomes)
            {

                Console.WriteLine(nome);
            }

            // convert um hashset e uma list.
            List<string> hashlist = setnomes.ToList();

            hashlist.Sort();
            
            foreach (var hash in hashlist)
            {
                Console.WriteLine(hash);
            }




        }
    }
}