using System.Collections.Generic;

namespace Library
{
    public class Paladin : Personaje
    {
        public Guantelete guantelete = new Guantelete();
        public EsferaDeHielo esfera = new EsferaDeHielo();
        public Paladin(string nombre)
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
            listaItemsNoMagicos.Add(guantelete);
            listaItemsNoMagicos.Add(esfera);
            ControlaMagia = false;
            registro = new PiedraEterna();
        }
    }
}