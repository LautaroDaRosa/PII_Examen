using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Clase que representa la forma de registrar las batallas que poseen los villanos,
    /// guarda cuáles son los héroes específicos que han sido vencidos por el propio villano.
    /// </summary>
    public class ArbolDeLosMilDias : IRegistro
    {
        public List<string> listaEnemigos{get;set;}
        public void Registrar(Personaje dueñoRegistro, Personaje ganador, Personaje perdedor)
        {
            if(dueñoRegistro==ganador)
            {
                listaEnemigos.Add(ganador.Nombre);
            }
        }
        public ArbolDeLosMilDias()
        {
            listaEnemigos = new List<string>();
        }
    }
}