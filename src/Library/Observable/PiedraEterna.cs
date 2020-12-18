using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Clase que representa la forma de registrar las batallas que poseen los héroes,
    /// guarda la cantidad de enemigos vencidos por el propio héroe.
    /// </summary>
    public class PiedraEterna : IRegistro
    {
        public List<string> listaEnemigos{get;set;}
        public int cantidadEnemigosVencidos;
        public void Registrar(Personaje dueñoRegistro, Personaje ganador, Personaje perdedor)
        {
            if(dueñoRegistro==ganador)
            {
                listaEnemigos.Add($"{ganador.Nombre} ha derrotado a {perdedor.Nombre}");
                cantidadEnemigosVencidos = listaEnemigos.Count;
            }

        }
        public PiedraEterna()
        {
            listaEnemigos = new List<string>();
            cantidadEnemigosVencidos = 0;
        }
    }
}