namespace Library
{
    public class Rayo : IHechizo
    {
        public int Ataque{get;set;}
        public int Defensa{get;set;}
        public int Curacion{get;set;}
        public Rayo()
        {
            Ataque = 10;
            Defensa = 0;
            Curacion = 0;
        }
    }
}