namespace Library
{
    public class AmuletoDeLaSalud : IItems
    {
        public int Ataque {get;set;}
        public int Defensa {get;set;}
        public int Curacion {get;set;}
        public bool EsMagico{get;set;}
        public AmuletoDeLaSalud()
        {
            Ataque = 0;
            Defensa = 0;
            Curacion = 30;
            EsMagico = false;
        }
    }
}