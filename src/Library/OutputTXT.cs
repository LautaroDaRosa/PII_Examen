using System.Collections.Generic;
using System.IO;
using System;
namespace Library
{
    /// <summary>
    /// Clase encargada de escribir la historia en un archivo ".txt".
    /// </summary>
    /// Cumple con el principio SRP ya que su única responsabilidad es escribir en el archivo ".txt"
    /// para finalizar el programa, recibe el string "historias" y lo graba en el archivo indicado.
    public class OutputTXT : IOutput
    {
        public string Historia;
        public void EscribirArchivo(List<string> historias)
        {
            foreach(string contenido in historias)
            {   
                Historia += contenido;
            }
            File.WriteAllText("Historia.txt",Historia);
        }
    }
}