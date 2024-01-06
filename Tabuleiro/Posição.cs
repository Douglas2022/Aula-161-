namespace tabuleiro
{
    class Posição
    {
        public int linha { get; set; }
        public int coluna { get; set; }

        public Posição(int linha,int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public override string ToString()
        {
            return linha
                + ", "
                + coluna;
        }
    }
}
