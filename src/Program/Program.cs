using System;
using Library;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Se utiliza un item combinado en el demonio para probar el método
            Demonio demonio = new Demonio("Demonio");
            demonio.CombinarItems(demonio.anillo, demonio.gema);
            //Se agregan objetos para probar la excepción de si pertencian al personaje al quitarlos 
            Personaje elfo = new Elfo("Elfo");
            Personaje enano = new Enano("Enano");
            Espada espada = new Espada();
            elfo.AgregarObjetos(espada);
            try
            {
                elfo.Intercambiar(enano, espada);
            }
            catch(QuitarItemException e)
            {
                Console.WriteLine(e.Message);
                System.Environment.Exit(0);
            }
            enano.AgregarObjetos(espada);
            try
            {
                enano.EliminarObjetos(espada);
            }
            catch(QuitarItemException e)
            {
                Console.WriteLine(e.Message);
                System.Environment.Exit(0);
            }
            //Se crea el escenario y los handlers
            Escenario escenario = new Escenario();
            InstanciacionDeHandlers.GetInstance().Crear();
            //Se crea el input y se utiliza la excepción en caso de que haya un error al 
            //ingresar la ruta del archivo
            try
            {
                IInput input = new InputTXT();
                escenario.listaCrearPersonajes = input.ProcesarArchivo();
            }
            catch(ArchivoNoEncontradoException e)
            {
                Console.WriteLine("No se encontró el archivo para procesar las encuentros, revise la ruta del mismo.");
                Console.WriteLine(e.Message);
                System.Environment.Exit(1);
            }
            try
            {
                escenario.CrearPersonajes();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                System.Environment.Exit(1);
            }
            //Se crean todas las batallas
            escenario.CrearBatallas();
            //Se crea el output
            IOutput output = new OutputTXT();
            //Se escribe la historia en el archivo
            output.EscribirArchivo(escenario.listaHistoria);
        }
    }
}
