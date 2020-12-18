using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Clase que representa al Libro de Hechizos el cual es un item mágico y excepcional, posee 
    /// una lista de hechizos y permite al dueño del mismo aumentar su ataque, defensa y curación
    /// en la cantidad que sus hechizos lo permitan.
    /// </summary>
    /// Cumple con el patrón Expert, ya que la clase es experta en la información que necesita
    /// para cumplir con sus responsabilidades, para hacer uso del método "SumarHechizos" utiliza 
    /// la lista de hechizos que es propia de la clase.
    /// 
    /// Cumple con el patrón Creator ya que agrega objetos de las clases que implementan la
    /// interfaz "IHechizo" en el atributo propio "lista".
    public class LibroDeHechizos : IItems
    {
        public int Ataque{get;set;}
        public int Defensa{get;set;}
        public int Curacion{get;set;}
        public bool EsMagico{get;set;}
        public List<IHechizo> lista;
        public LibroDeHechizos()
        {
            EsMagico = true;
            BolaDeFuego bola = new BolaDeFuego();
            ConjuroDefensivo conjuro = new ConjuroDefensivo();
            Curar curar = new Curar();
            FlechaArcana flecha = new FlechaArcana();
            Rayo rayo = new Rayo();
            lista = new List<IHechizo>();
            lista.Add(bola);
            lista.Add(conjuro);
            lista.Add(curar);
            lista.Add(flecha);
            lista.Add(rayo);
            this.SumarHechizos();
        }
        public void SumarHechizos()
        {
            foreach(IHechizo hechizo in lista)
            {
                this.Ataque += hechizo.Ataque;
                this.Defensa += hechizo.Defensa;
                this.Curacion += hechizo.Curacion;
            }
        }

    }
}