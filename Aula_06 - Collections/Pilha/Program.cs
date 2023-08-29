namespace Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> Pilha = new Stack<string>();

            Pilha.Push("Brenno");// pra mudar varias de uma vez selecionar escrever a palavra e da um tab.
            Pilha.Push("Edu");
            Pilha.Push("Julia");
            Pilha.Push("Leonardo");
            Pilha.Push("Gaspar");

            Pilha.Pop();

            foreach (var nome in Pilha)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine(" Qual o Ultimo da fila: " + Pilha.Peek());

            // verificar se tal elemento esta na fila
            Console.WriteLine(" O Gaspar entrou na fila?: " + Pilha.Contains("Gaspar"));

            // pra ver quantas pessoas tem na fila
            Console.WriteLine(" Quanto numeros de pessoas na fila?: " + Pilha.Count());
        }
    }
}