using System;
using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Clase principal que maneja la información de gran parte del programa, representa cada 
    /// escenario en el que ocurren todos los combates entre los personajes, por ende se encarga 
    /// de crear todos los personajes que participarán de las batallas, también crea cada 
    /// una de las batallas que se librarán en el escenario, se encarga de verificar (mediante
    /// el uso también de excepciones) que los datos que se cargan por archivo sean correctos 
    /// para así representar los personajes en cada escenario y batalla. 
    /// </summary>
    /// 
    /// Cumple con el patrón Creator ya que tiene los datos que serán provistos al constructor 
    /// para inicializar instancias de la clase "Batalla" por lo que la clase "Escenario" es 
    /// experta con respecto a crear "Batalla".
    /// También lo cumple ya que agrega objetos de las clases que heredan de Personaje 
    /// (Demonio, Enano, Elfo, etc) en el atributo propio "listaPersonajesEncuentro".
    public class Escenario
    {
        public List<List<string>> listaCrearPersonajes;
        public List<Personaje> listaPersonajesEncuentro;
        public List<List<Personaje>> listaBatallas = new List<List<Personaje>>();
        public List<string> listaHistoria = new List<string>(); 
        public void CrearPersonajes()
        {
            foreach(List<string> lista in listaCrearPersonajes)
            {
                ValidarPersonajes(lista);
                listaPersonajesEncuentro = new List<Personaje>();
                for(int i=0;i<lista.Count;i+=2)
                {
                    for(int a=0;a<Convert.ToInt32(lista[i]);a++)
                        {
                            InstanciacionDeHandlers handlers = InstanciacionDeHandlers.GetInstance();
                            Personaje nuevoPersonaje = handlers.primerHandler.Handle(lista[i+1]);
                            listaPersonajesEncuentro.Add(nuevoPersonaje);
                        }
                }
                listaBatallas.Add(listaPersonajesEncuentro);
            }
        }
        public void CrearBatallas()
        {
            foreach(List<Personaje> lista in listaBatallas)
            {
                Batalla batalla = new Batalla(lista);
                batalla.Combate();
                listaHistoria.Add(batalla.historia.Combates);
            }       
        }

        public void ValidarPersonajes(List<string> batalla)
        {
            if(batalla.Count%2!=0)
            {
                throw new FormatoInvalidoException("Formato inválido, se debe especificar la cantidad de personajes y luego la raza para todos los bandos en cada batalla.");
            }
            for(int i=0;i<batalla.Count;i++)
            {
                if(batalla[i]==null || batalla[i]=="")
                {
                    throw new FormatoInvalidoException("Formato inválido, el tipo de raza o la cantidad de personajes no puede ser vacío.");
                }
            }
            for(int i=0;i<batalla.Count;i+=2)
            {
                if(System.Convert.ToInt32(batalla[i])<=0)
                {
                    throw new FormatoInvalidoException("Formato inválido, se debe especificar la cantidad de personajes con un número mayor a cero.");
                }
            }
        }
    }
}