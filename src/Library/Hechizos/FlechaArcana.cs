namespace Library
{
    public class FlechaArcana : IHechizo
    {
        public int Ataque{get;set;}
        public int Defensa{get;set;}
        public int Curacion{get;set;}
        public FlechaArcana()
        {
            Ataque = 5;
            Defensa = 0;
            Curacion = 0;
        }
    }
}