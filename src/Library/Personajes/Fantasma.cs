using System.Collections.Generic;

namespace Library
{
    public class Fantasma : Personaje
    {
        public BastonCurativo baston = new BastonCurativo();
        public PocionDeSalud pocion = new PocionDeSalud();
        public Fantasma(string nombre)
        {
            this.Nombre = nombre;
            EsHeroe = false;
            IsDead = false;
            VidaMaxima = 50;
            VidaActual = VidaMaxima;
            Ataque = 25;
            Defensa = 5;
            PuntosDeVictoria = 3;
            listaItemsMagicos = new List<IItems>();
            listaItemsNoMagicos = new List<IItems>();
            listaItemsNoMagicos.Add(baston);
            listaItemsNoMagicos.Add(pocion);
            ControlaMagia = false;
            registro = new ArbolDeLosMilDias();
        }
    }
}