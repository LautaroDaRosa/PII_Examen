namespace Library
{
    public class EsferaDeHielo : IItems
    {
        public int Ataque {get;set;}
        public int Defensa {get;set;}
        public int Curacion {get;set;}
        public bool EsMagico{get;set;}
        public EsferaDeHielo()
        {
            Ataque = 10;
            Defensa = 0;
            Curacion = 0;
            EsMagico = false;
        }
    }
}