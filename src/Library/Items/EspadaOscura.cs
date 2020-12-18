namespace Library
{
    public class EspadaOscura : IItems
    {
        public int Ataque{get;set;}
        public int CantidadDeGemas{get;set;}
        public int Defensa{get;set;}
        public int Curacion { get;set; }
        public bool EsMagico{get;set;}
        public void RecibirGemas(int num)
        {
            CantidadDeGemas += num;
            Ataque = 5*CantidadDeGemas;
        }
        public EspadaOscura()
        {
            EsMagico = false;
            Ataque = 5*CantidadDeGemas;
            CantidadDeGemas = 1;
        }
    }
}