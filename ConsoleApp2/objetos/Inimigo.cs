using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos
{
    public class Inimigo
    {
        public int Dano { get; set; }
        public int Vida { get; set; }
        public int Nivel { get; set; }

        public Inimigo(int dano, int vida) 
        {
            Dano = dano;
            Vida = vida;
            Nivel =1;
        }


    }
}
    


