using tabuleiro;
namespace xadrez
{
    //classe torre e uma subclasse da classe peca
    class Torre  : Peca
    {
        //criando objeto torre
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }
        //metodo tostring pro torre
        public override string ToString()
        {
            return "T";
        }
    }
}

