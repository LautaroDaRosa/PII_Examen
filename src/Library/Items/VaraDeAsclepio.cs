using System.Collections.Generic;

namespace Library
{
    public class VaraDeAsclepio : IItems
    {
        public int Ataque{get;set;}
        public int Defensa{get;set;}
        public int Curacion{get;set;}
        public bool EsMagico{get;set;}
        public Personaje dueño;
        public VaraDeAsclepio(Personaje dueño)
        {
            Ataque = 0;
            Defensa = 0;
            Curacion = 0;
            EsMagico = true;
            dueño.ControlaMagia=true;
        }
    }
}