using xadrez;
using tabuleiro;
using Xadrez_Console;

namespace XadrezConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
             PosicaoXadrez pos = new PosicaoXadrez('c',7);
             Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
                
            
            Console.WriteLine();
        }
    }
}
