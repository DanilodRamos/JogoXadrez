using tabuleiro;
namespace xadrez
{
    //classe rei e uma subclasse da classe peca
    class Rei : Peca
    {
        //criando objeto rei
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }
            //metodo tostring pro rei
            public override string ToString()
        {
            return "R";
        }
    }
}


