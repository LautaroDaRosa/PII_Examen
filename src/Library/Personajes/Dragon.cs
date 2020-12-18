using System.Collections.Generic;

namespace Library
{
    public class Dragon : Personaje
    {
        public AmuletoDeLaSalud amuleto = new AmuletoDeLaSalud();
        public Talisman talisman = new Talisman();
        public Dragon(string nombre)
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
            listaItemsNoMagicos.Add(amuleto);
            listaItemsNoMagicos.Add(talisman);
            ControlaMagia = false;
            registro = new ArbolDeLosMilDias();
        }
    }
}