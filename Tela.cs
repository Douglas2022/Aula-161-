using System;
using System.Diagnostics.Eventing.Reader;
using tabuleiro;


namespace Xadre_
{
    class Tela
    {
        public static void imprmirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i<tabuleiro.Linha; i++)
            {
                for (int j = 0; j < tabuleiro.Linha; i++)
                    if (Tabuleiro.Peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tabuleiro.peca(i,j) + " ");
                    }
                Console.WriteLine();

            }
        }
    }
}
