class program 
{
    static void Main(string[] args)
    {
        var casa = new Casa ();
        casa.Moradores = 5;
        casa.Quartos = "Grandes";
        casa.concluido = false;
        casa.altura = 8.17;
        DadosDaCasa(casa);
    }
    public static void DadosDaCasa(Casa casa){
        console.writeline(casa.altura);
        console.writeline(casa.concluido);
    }
    public class construcao {
        public string cor;
        public double altura;
        public double largura;
        public bool concluido;
}

    public class casa : construcao{

        public string Quartos;
        public string sala;
}
}
