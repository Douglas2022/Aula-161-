using System;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        private Peca[,] pecas;
        private int coluna;

        public Tabuleiro(int linha, int coluna)
        {
            Linha = Linha;
            Coluna = Coluna;
            pecas = new Peca[linha, coluna];
        }
        public Peca peca(int Linha, int Coluna)
        {
            return pecas[Linha, Coluna];
        }
        public void colocarPecas(Peca p, Posição pos)
        {
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
        
    }
}
