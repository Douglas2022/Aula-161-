using System;
using tabuleiro;
using Xadrez;

namespace Xadre_
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPecas(new Torre(tab, Cor.Preta), new Posição(0, 0));
            tab.colocarPecas(new Torre(tab, Cor.Preta), new Posição(1, 3));
            tab.colocarPecas(new Rei(tab, Cor.Preta), new Posição(2, 4));

            Tela.imprmirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}