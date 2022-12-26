
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
        //criando uma sobrecarga no metodo peca
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }
        //criando metodo testar
        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        //colocando pecas no tabuleiro
        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Ja Existe uma peca  nessa posicao! :");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
        //retirando pecas do tabuleiro
        public Peca retirarPeca(Posicao pos)
        {
            if (peca(pos) == null)
            {
                return null;
            }
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
        }
        //criando metodo para testar se posicao e valida
        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha< 0 || pos.linha >=linhas || pos.coluna<0 || pos.coluna>= colunas){
                return false;
            }
            return true;

        }
        //criando metodo para validar posicao
        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posicao invalida!");
            }
        }

    }
}

