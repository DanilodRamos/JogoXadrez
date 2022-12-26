namespace tabuleiro
{
    class Posicao
    {
        public int linha { get; set; }
        public int coluna { get; set; }
        //criando construtor
        public Posicao(int linha,int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }
        //convertendo para tostring
        public override string ToString()
        {
            return linha
                +", "
                + coluna;
        }
    }
}
