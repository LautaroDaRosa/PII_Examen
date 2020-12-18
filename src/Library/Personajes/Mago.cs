using System;
using System.Collections.Generic;

namespace Library
{
    public class Mago : Personaje
    {
        public LibroDeHechizos libro = new LibroDeHechizos();
        public Machete machete = new Machete();
        public Mago(string nombre)
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
            listaItemsMagicos.Add(libro);
            listaItemsNoMagicos.Add(machete);
            ControlaMagia = true;
            registro = new LibroDeLaSabiduria();
        }
    }
}
