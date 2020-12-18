using System.Collections.Generic;

namespace Library
{
    public class Esqueleto : Personaje
    {
        public Hacha hacha = new Hacha();
        public Armadura armadura = new Armadura();
        public Esqueleto(string nombre)
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
            listaItemsNoMagicos.Add(hacha);
            listaItemsNoMagicos.Add(armadura);
            ControlaMagia = false;
            registro = new ArbolDeLosMilDias();
        }
    }
}