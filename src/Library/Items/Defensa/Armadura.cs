namespace Library
{
    public class Armadura : IItems
    {
        public int Ataque {get;set;}
        public int Defensa {get;set;}
        public int Curacion {get;set;}
        public bool EsMagico{get;set;}
        public Armadura()
        {
            Ataque = 0;
            Defensa = 15;
            Curacion = 0;
            EsMagico = false;
        }
    }
}