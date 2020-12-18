using System.Collections.Generic;

namespace Library
{
    public class Orco : Personaje
    { 
        public EspadaOscura espada = new EspadaOscura();
        public Mazo mazo = new Mazo();
        public Orco(string nombre)
        {
            this.Nombre = nombre;
            EsHeroe = false;
            IsDead = false;
            VidaMaxima = 50;
            VidaActual = VidaMaxima;
            Ataque = 10;
            Defensa = 5;
            PuntosDeVictoria = 3;
            listaItemsMagicos = new List<IItems>();
            listaItemsNoMagicos = new List<IItems>();
            listaItemsNoMagicos.Add(espada);
            listaItemsNoMagicos.Add(mazo);
            ControlaMagia = false;
            registro = new ArbolDeLosMilDias();
        }
    }
}