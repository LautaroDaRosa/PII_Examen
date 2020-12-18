using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Interfaz que implementan las clases que cargan los datos del escenario, esta interfaz permite
    /// modificar la fuente de dónde se obtienen los datos sin modificar prácticamente el código ya
    /// que sólo hace falta crear una clase que implemente esta interfaz e instanciarla en la clase
    /// "Program" para cambiar la forma de cargar los datos.
    /// </summary>
    /// 
    /// Cumple con el patrón Polimorfismo, ya que la operación "ProcesarArchivo", es una
    /// operación polimórfica, ya que la implementan múltiples objetos de todas las clases 
    /// que implementan esta interfaz, aunque sólo "InputTXT" implementa esta interfaz 
    /// cumple con el patrón ya que en lugar de preguntar por el tipo del objeto usa 
    /// lógica condicional para ejecutar código que varía segun el tipo.
    public interface IInput
    {
        List<string> listaPersonajesEncuentro{get;set;}
        List<List<string>> ProcesarArchivo();
    }
}