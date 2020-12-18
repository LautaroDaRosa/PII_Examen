using System;
using System.Collections.Generic;
using Microsoft.CSharp;
using System.CodeDom.Compiler;

namespace Library
{
    /// <summary>
    /// Clase encargada de interpretar un archivo ".txt" y así procesar la información de los personajes
    /// involucrados en los encuentros.
    /// </summary>
    /// Cumple con el principio SRP ya que cumple con una única responsabilidad la cual es leer 
    /// el archivo ".txt" y obtener los datos del mismo, luego le pasa la información a la clase 
    /// encargada de instanciar los personajes que correspondan para que así se desarrolle el 
    /// resto del programa.
    public class InputTXT : IInput
    {
        public List<string> listaPersonajesEncuentro{get;set;}
        public List<List<string>> ProcesarArchivo()
        {
            string archivo = "Escenario.txt";
            List<List<string>> listaPersonajesEscenario = new List<List<string>>();
            string[] leerArchivo = null;
            try
            {
                // try
                // {
                    leerArchivo = System.IO.File.ReadAllLines(archivo);
                // }
                // catch(ArchivoNoEncontradoException e)
                // {
                //     throw new ArchivoNoEncontradoException(e.Message);
                // }    
                foreach(string linea in leerArchivo)
                {
                    string [] lista = linea.Split(',');
                    listaPersonajesEncuentro = new List<string>();
                    foreach(string palabra in lista)
                    {
                        listaPersonajesEncuentro.Add(palabra);
                    }
                    listaPersonajesEscenario.Add(listaPersonajesEncuentro);
                }
            }
            catch(Exception e)
            {
                throw new ArchivoNoEncontradoException(e.Message);
            }
            return listaPersonajesEscenario;
        }
    }
}