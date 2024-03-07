namespace objetos
{
    public class jogador
    {
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public int Dano { get; set; }
        public int Cura { get; set; }
        public int Vida { get; set; }
        public TipoArmaEnum TipoArma { get; set; }

        public jogador(string nome,int dano, TipoArmaEnum tipoArma)
        {
            Nome = nome;
            Nivel = 1;
            Dano = dano;
            TipoArma = tipoArma;
        }
    }


}