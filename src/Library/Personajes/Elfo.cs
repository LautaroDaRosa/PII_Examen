using System.Collections.Generic;

namespace Library
{
    public class Elfo : Personaje
    {
        public MascaraDeLaMuerte mascara = new MascaraDeLaMuerte();
        public EsferaDeFuego esfera = new EsferaDeFuego();
        public Elfo(string nombre)
        {
            this.Nombre = nombre;
            EsHeroe = true;
            IsDead = false;
            VidaMaxima = 50;
            VidaActual = VidaMaxima;
            Ataque = 10;
            Defensa = 5;
            PuntosDeVictoria = 3;
            listaItemsMagicos = new List<IItems>();
            listaItemsNoMagicos = new List<IItems>();
            listaItemsNoMagicos.Add(mascara);
            listaItemsNoMagicos.Add(esfera);
            ControlaMagia = false;
            this.registro = new PiedraEterna();
        }
    }
}