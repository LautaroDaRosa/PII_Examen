using System.Collections.Generic;

namespace Library
{
    public class Demonio : Personaje
    {
        public Anillo anillo = new Anillo();
        public GemaEncantada gema = new GemaEncantada();
        public Demonio(string nombre)
        {
            this.Nombre = nombre;
            EsHeroe = false;
            IsDead = false;
            VidaMaxima = 50;
            VidaActual = VidaMaxima;
            Ataque = 20;
            Defensa = 5;
            PuntosDeVictoria = 3;
            listaItemsMagicos = new List<IItems>();
            listaItemsNoMagicos = new List<IItems>();
            anillo = new Anillo();
            listaItemsNoMagicos.Add(anillo);
            listaItemsNoMagicos.Add(gema);
            ControlaMagia = false;
            registro = new ArbolDeLosMilDias();
        }
    }
}