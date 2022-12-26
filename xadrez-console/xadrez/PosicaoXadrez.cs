using tabuleiro;
    namespace xadrez
{
    class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }
        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }
        //transforma para uma posicao normal
        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }
            //transforma para tostring 
        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
