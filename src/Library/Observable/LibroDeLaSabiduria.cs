using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Clase que representa la forma de registrar las batallas que poseen los magos,
    /// guarda el resultado de cada enfrentamiento en el que un personaje muere, indicando
    /// que personaje es y cual fue el que le derrotó.
    /// </summary>
    public class LibroDeLaSabiduria : IRegistro
    {
        public List<string> listaEnemigos{get;set;}
        public void Registrar(Personaje dueñoRegistro, Personaje ganador, Personaje perdedor)
        {
            listaEnemigos.Add($"{ganador.Nombre} ha derrotado a {perdedor.Nombre}");
        }
        public LibroDeLaSabiduria()
        {
            listaEnemigos = new List<string>();
        }
    }
}