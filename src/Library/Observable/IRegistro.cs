using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Interfaz que permite a los personajes llevar un registro genérico en cuanto a las 
    /// batallas que han librado y así poder guardar la información de la manera que lo 
    /// necesite implementar cada personaje. 
    /// </summary>
    public interface IRegistro
    {
        List<string> listaEnemigos{get;set;}
        void Registrar(Personaje dueñoRegistro, Personaje ganador, Personaje perdedor);
    }
}