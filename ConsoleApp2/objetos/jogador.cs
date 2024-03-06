namespace objetos
{
    public class jogador
    {
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public int Dano { get; set; }
        public int Cura { get; set; }

        public jogador(string nome,int dano)
        {
            Nome = nome;
            Nivel = 1;
            Dano = dano;
        }
    }


}