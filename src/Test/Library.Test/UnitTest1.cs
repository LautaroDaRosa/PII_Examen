using NUnit.Framework;
using System.Collections.Generic;
using System;

namespace Library.Test
{
    public class Tests
    {
        Personaje personaje1;
        Personaje personaje2;
        IItems espada;
        IItems botas;
        IItems arco;
        IItems yelmo;
        Batalla batalla;
        List<Personaje> listaPersonajes;
        string comprobante;

        [SetUp]
        public void Setup()
        {
            personaje1 = new Elfo("Elfo");
            personaje2 = new Demonio("Demonio");
            espada = new Espada();
            botas = new Botas();
            arco = new Arco();
            yelmo = new Yelmo();
            listaPersonajes = new List<Personaje>();
            listaPersonajes.Add(personaje1);
            listaPersonajes.Add(personaje2);
            batalla = new Batalla(listaPersonajes);
            comprobante = "";
        }

        [Test]
        public void PersonajeMuerto()
        {
            personaje1.VidaActual = 1;
            personaje2.Atacar(personaje1);
            Assert.AreEqual(personaje1.IsDead, true);
        }

        [Test]
        public void PersonajeVivo()
        {
            Assert.AreEqual(personaje1.IsDead, false);
        }

        [Test]
        public void AgregarItemAtaque()
        {
            personaje1.AgregarObjetos(espada);
            personaje1.CalcularAtaque();
            Assert.AreEqual(personaje1.AtaqueTotal, 40);
        }

        [Test]
        public void AgregarItemDefensa()
        {
            personaje1.AgregarObjetos(botas);
            personaje1.CalcularDefensa();
            Assert.AreEqual(personaje1.DefensaTotal, 25);
        }
        
        [Test]
        public void QuitarItemAtaque()
        {
            personaje1.AgregarObjetos(espada);
            personaje1.EliminarObjetos(espada);
            personaje1.CalcularAtaque();
            Assert.AreEqual(personaje1.AtaqueTotal, 20);
        }

        [Test]
        public void QuitarItemDefensa()
        {
            personaje1.AgregarObjetos(botas);
            personaje1.EliminarObjetos(botas);
            personaje1.CalcularDefensa();
            Assert.AreEqual(personaje1.DefensaTotal, 15);
        }

        [Test]
        public void Agregar2ItemAtaque()
        {
            personaje1.AgregarObjetos(espada);
            personaje1.AgregarObjetos(arco);
            personaje1.CalcularAtaque();
            Assert.AreEqual(personaje1.AtaqueTotal, 50);
        }

        [Test]
        public void Agregar2ItemDefensa()
        {
            personaje1.AgregarObjetos(botas);
            personaje1.AgregarObjetos(yelmo);
            personaje1.CalcularDefensa();
            Assert.AreEqual(personaje1.DefensaTotal, 40);
        }

        [Test]
        public void RecibirAtaque()
        {
            personaje2.Atacar(personaje1);
            Assert.AreEqual(personaje1.VidaActual, 45);
        }

        [Test]
        public void RecibirAtaqueVida0()
        {
            personaje1.VidaActual = 1;
            personaje2.Atacar(personaje1);
            Assert.AreEqual(personaje1.VidaActual, 0);
        }

        [Test]
        public void RecibirAtaqueDefensaMayor()
        {
            personaje1.Defensa = 100;
            personaje2.Atacar(personaje1);
            Assert.AreEqual(personaje1.VidaActual, 50);
        }

        [Test]
        public void Intercambio()
        {
            personaje1.AgregarObjetos(espada);
            personaje1.Intercambiar(personaje2,espada);
            Assert.AreEqual(personaje1.listaItemsNoMagicos.Count, 2);
            Assert.AreEqual(personaje2.listaItemsNoMagicos.Count, 3);
        }

        [Test]
        public void IntercambioMultiple()
        {
            personaje1.AgregarObjetos(espada);
            personaje1.AgregarObjetos(botas);
            personaje1.AgregarObjetos(arco);
            personaje1.AgregarObjetos(yelmo);
            personaje1.Intercambiar(personaje2,espada);
            personaje1.Intercambiar(personaje2,botas);
            personaje1.Intercambiar(personaje2,arco);
            personaje1.Intercambiar(personaje2,yelmo);
            Assert.AreEqual(personaje1.listaItemsNoMagicos.Count, 2);
            Assert.AreEqual(personaje2.listaItemsNoMagicos.Count, 6);
        }

        [Test]
        public void Combate()
        {
            personaje1.Ataque = 0;
            personaje1.Defensa = 0;
            personaje2.Defensa = 0;
            batalla.Combate();
            Assert.AreEqual(personaje1.IsDead, true);
            Assert.AreEqual(personaje2.IsDead, false);
        }

        [Test]
        public void QuitarItemExcepcion()
        {
            try
            {
                personaje1.EliminarObjetos(espada);
            }
            catch(Exception e)
            {
                comprobante = e.Message;
            }
            Assert.AreEqual(comprobante,"No se puede quitar un item que no se posee.");
        }

        [Test]
        public void IntercambioExcepcion()
        {
            try
            {
                personaje1.Intercambiar(personaje2,espada);
            }
            catch(Exception e)
            {
                comprobante = e.Message;
            }
            Assert.AreEqual(comprobante,"No se puede intercambiar un item que no se posee.");
        }
    }
}