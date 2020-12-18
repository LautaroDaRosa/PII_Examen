using System.Collections.Generic;

namespace Library
{
    public class Enano : Personaje
    {
        public Grebas grebas = new Grebas();
        public Yelmo yelmo = new Yelmo();
        public Enano(string nombre)
        {
            this.Nombre = nombre;
            EsHeroe = true;
            IsDead = false;
            VidaMaxima = 100;
            VidaActual = VidaMaxima;
            Ataque = 20;
            Defensa = 15;
            PuntosDeVictoria = 3;
            listaItemsMagicos = new List<IItems>();
            listaItemsNoMagicos = new List<IItems>();
            listaItemsNoMagicos.Add(grebas);
            listaItemsNoMagicos.Add(yelmo);
            ControlaMagia = false;
            registro = new PiedraEterna();
        }
    }
}