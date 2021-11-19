namespace tabuleiro
{
    class Posicao
    {
        public int Liha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int liha, int coluna)
        {
            Liha = liha;
            Coluna = coluna;
        }

        public override string ToString()
        {
            return Liha
                + ", "
                + Coluna;
        }
    }
}
