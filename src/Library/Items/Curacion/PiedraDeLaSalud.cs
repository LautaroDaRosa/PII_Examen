namespace Library
{
    public class PiedraDeLaSalud : IItems
    {
        public int Ataque {get;set;}
        public int Defensa {get;set;}
        public int Curacion {get;set;}
        public bool EsMagico{get;set;}
        public PiedraDeLaSalud()
        {
            Ataque = 0;
            Defensa = 0;
            Curacion = 20;
            EsMagico = false;
        }
    }
}