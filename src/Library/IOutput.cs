using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Interfaz que implementan las clases que escriben los datos de la historia en un archivo,
    /// esta interfaz permite cambiar la forma de escribir los datos o el tipo de archivo en el
    /// que se guardan sin modificar prácticamente el código ya que sólo hace falta crear una 
    /// clase que implemente esta interfaz e instanciarla en la clase "Program".
    /// </summary>
    ///
    /// Cumple con el patrón Polimorfismo, ya que la operación "EscribirArchivo", es una
    /// operación polimórfica, ya que la implementan múltiples objetos de todas las clases 
    /// que implementan esta interfaz, aunque sólo "OutputTXT" implementa esta interfaz 
    /// cumple con el patrón ya que en lugar de preguntar por el tipo del objeto usa 
    /// lógica condicional para ejecutar código que varía segun el tipo.
    public interface IOutput
    {
        void EscribirArchivo(List<string> historias);
    }
}