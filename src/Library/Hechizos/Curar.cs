namespace Library
{
    public class Curar : IHechizo
    {
        public int Ataque{get;set;}
        public int Defensa{get;set;}
        public int Curacion{get;set;}
        public Curar()
        {
            Ataque = 0;
            Defensa = 0;
            Curacion = 25;
        }
    }
}