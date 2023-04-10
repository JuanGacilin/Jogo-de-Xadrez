using System;
using tabuleiro;
using Xadrez_Console;

namespace XadrezConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);
            
                Console.WriteLine();
        }
    }
}
