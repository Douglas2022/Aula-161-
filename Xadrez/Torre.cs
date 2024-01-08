using tabuleiro;
namespace Xadrez
{
    class Torre:Peca
    {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {

        }
        public override string ToString()
        {
            return "T";
        }
    }

}
