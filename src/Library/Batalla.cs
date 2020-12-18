using System;
using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Clase que representa los encuentros de batalla entre los personajes, recibe una lista
    /// de personajes para así desarrollar los combates entre sí siguiendo la lógica que tienen
    /// los mismos, también determina qué bando resulta vencedor de cada batalla y lo añade 
    /// a la historia.
    /// </summary>
    /// 
    /// Cumple con el patrón Creator ya que agrega objetos de las clases que heredan de Personaje 
    /// (Demonio, Enano, Elfo, etc) en el atributo propio "listaPersonajes".
    /// También lo cumple ya que contiene objetos y guarda instancias de las clases 
    /// "TorreDeLosCaidos" e "Historia".
    public class Batalla
    {
        public List<Personaje> listaPersonajes;
        public List<Personaje> listaHeroes;
        public List<Personaje> listaVillanos;
        public int cantidadVillanos;
        public int cantidadHeroes;
        public TorreDeLosCaidos torre;
        public Historia historia;
        public Batalla(List<Personaje> lista)
        {
            this.torre = new TorreDeLosCaidos();
            this.historia = new Historia();
            this.torre.Subscribe(historia);
            this.listaPersonajes = lista;
            this.listaHeroes = new List<Personaje>();
            this.listaVillanos = new List<Personaje>();
            this.cantidadHeroes = 0;
            this.cantidadVillanos = 0;
        }
        public void Combate()
        {
            this.historia.Combates += "Comienza la batalla!\n";
            foreach(Personaje personaje in this.listaPersonajes)
            {
                this.torre.Subscribe(personaje);
                if(personaje.EsHeroe==true)
                {
                    this.listaHeroes.Add(personaje);
                }
                else
                {
                    this.listaVillanos.Add(personaje);
                }
            }
            this.cantidadVillanos = listaVillanos.Count;
            this.cantidadHeroes = listaHeroes.Count;
            while(this.cantidadVillanos>0 && this.cantidadHeroes>0)
            {
                int indice = 0;
                for(int i=0;i<this.listaVillanos.Count;i++)
                {
                    if(this.listaHeroes.Count<=i)
                    {
                        if(this.listaHeroes[indice].IsDead==false && this.listaVillanos[i].IsDead==false)
                        {
                            this.listaVillanos[i].Atacar(this.listaHeroes[indice]);
                            if(this.listaHeroes[indice].IsDead)
                            {
                                this.torre.NotifyObservers(this.listaVillanos[i], this.listaHeroes[indice]);
                                this.cantidadHeroes += -1;
                            }
                            indice++;
                        }
                        if(indice==this.listaHeroes.Count)
                        {
                            indice = 0;
                        }
                    }
                    else
                    {
                        if(this.listaHeroes[i].IsDead==false && this.listaVillanos[i].IsDead==false)
                        {
                            this.listaVillanos[i].Atacar(this.listaHeroes[i]);
                            if(this.listaHeroes[i].IsDead)
                            {
                                this.torre.NotifyObservers(this.listaVillanos[i], this.listaHeroes[i]);
                                this.cantidadHeroes += -1;
                            }
                        }
                    }
                }
                foreach(Personaje heroe in this.listaHeroes)
                {
                    foreach(Personaje villano in this.listaVillanos)
                    {
                        if(heroe.IsDead==false && villano.IsDead==false)
                        {
                            heroe.Atacar(villano);
                            if(villano.IsDead==true)
                            {
                                this.torre.NotifyObservers(heroe, villano);
                                this.cantidadVillanos += -1;
                                heroe.PuntosDeVictoria += villano.PuntosDeVictoria;
                            }
                            if(heroe.PuntosDeVictoria>=5)
                            {
                                heroe.PuntosDeVictoria -= 5;
                                heroe.Curar();
                            }
                        }
                    }
                }
            }
            this.historia.Combates += "Finaliza la batalla.\n";
            string vencedores;
            if(this.cantidadVillanos==0)
            {
                vencedores = "Los Heroes se han hecho con el control de la Tierra Media!";
            }
            else
            {
                vencedores = "Los Villanos se han hecho con el control de la Tierra Media!";
            }
            this.historia.Combates += vencedores + "\n\n";
            Console.WriteLine("La batalla ha finalizado");
        }
    }
}