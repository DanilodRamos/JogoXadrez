
namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        //matriz de pecas
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }
        //metodo para dar acesso ao peca
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }


    }
}

