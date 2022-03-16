using System;
using tabuleiro;
using xadrez;

namespace Xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                Tela.imprimirTabuleiro(partida.tab);
                Console.WriteLine();
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }



        }
    }
}
