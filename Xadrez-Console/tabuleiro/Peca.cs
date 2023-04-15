﻿namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimenos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Cor cor,Tabuleiro tab)
        {
            this.posicao = null;
            this.cor = cor;            
            this.qteMovimenos = 0;
            this.tab = tab;
        }

        public void incrementarQteMovimentos()
        {
            this.qteMovimenos++;
        }

        public void decrementarQteMovimentos()
        {
            this.qteMovimenos--;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for(int i = 0; i < tab.linhas; i++)
            {
                for(int j = 0; j < tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool movimentoPossivel(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
