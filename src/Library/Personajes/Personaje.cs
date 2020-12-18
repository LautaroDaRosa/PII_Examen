using System;
using System.Collections.Generic;

namespace Library
{
    /// <summary>
    /// Clase abstracta que representa cada personaje de la historia, posee un nombre, un valor de vida actual
    /// y una vida máxima, un valor de defensa propio, un valor de ataque propio, valores de defensa 
    /// total y ataque total otorgados por los items que posea, una lista de items, puntos de victoria,
    /// un booleano "IsDead" que indica si el personaje se encuentra muerto, y un registro que le 
    /// permite guardar datos y estadísticas de lo que ocurra durante la batalla. 
    /// Permite que los personajes ataquen mediante el método "Atacar" y de esta manera permite 
    /// realizar las batallas, también permite intercambiar items entre personajes.
    /// </summary>
    /// Cumple con el patrón Expert, ya que ciertos métodos utilizan su propia información para 
    /// poder cumplir con sus responsabilidades, es la clase experta en la información que necesita, 
    /// a la hora de calcular el ataque total utilizando el método "CalcularAtaque" utiliza la lista
    /// de items, la cual es propia del personaje, lo mismo sucede con los métodos "CalcularDefensa",
    /// "Curar", "AgregarObjetos" y "EliminarObjetos".
    /// 
    /// Cumple con el patrón Polimorfismo, ya que las operaciones "Atacar", "CalcularAtaque", 
    /// "CalcularDefensa", "Curar", "AgregarObjetos", "EliminarObjetos" y "Intercambiar" son 
    /// operaciones polimórficas, ya que las implementan múltiples objetos de todos los tipos/clases 
    /// que heredan de Personaje (por ejemplo las clases "Demonio" y "Enano").
    /// 
    /// Cumple con el patrón Creator ya que contiene objetos de las clases "IItems" y "IRegistro",
    /// o en este caso, de las clases que implementan éstas interfaces.
    /// 
    /// Cumple con el principio OCP ya que es abierta a la extensión mediante herencia (así como 
    /// lo hace la clase "Mago"), y es cerrada a la modificación.
    public abstract class Personaje : IObserver
    {
        public string Nombre;
        public int VidaActual;
        public int VidaMaxima;
        public int Defensa;
        public int DefensaTotal;
        public int Ataque;
        public int AtaqueTotal;
        public List<IItems> listaItemsNoMagicos;
        public List<IItems> listaItemsMagicos;
        public int PuntosDeVictoria;
        public bool EsHeroe;
        public bool ControlaMagia;
        public bool IsDead;
        public IRegistro registro;
        // public void ImprimirRegistro()
        // {
        //     foreach(string line in registro.listaEnemigos)
        //     {
        //         Console.WriteLine(line);
        //     }
        // }
        public void CombinarItems(IItems item1, IItems item2)
        {
            List<IItems> lista = new List<IItems>();
            lista.Add(item1);
            lista.Add(item2);
            foreach(IItems item in lista)
            {   
                if(item.EsMagico)
                {
                    bool contiene = this.listaItemsMagicos.Contains(item);
                    if(contiene==false)
                    {
                        throw new QuitarItemException("No se puede combinar un item que no se posee.");
                    }
                    this.listaItemsMagicos.Remove(item);
                }
                else
                {
                    bool contiene = this.listaItemsNoMagicos.Contains(item);
                    if(contiene==false)
                    {
                        throw new QuitarItemException("No se puede combinar un item que no se posee.");
                    }
                    this.listaItemsNoMagicos.Remove(item);
                }
            }
            IItems itemCompuesto = new ItemCompuesto(item1,item2);
            if(itemCompuesto.EsMagico)
            {
                this.listaItemsMagicos.Add(itemCompuesto);
            }
            else
            {
                this.listaItemsNoMagicos.Add(itemCompuesto);
            }
        }
        public void Update(Personaje ganador, Personaje perdedor)
        {
            registro.Registrar(this, ganador, perdedor);
        }
        public void Atacar(Personaje personaje)
        {
            int daño = this.CalcularAtaque() - personaje.CalcularDefensa();
            if(daño<0)
            {
                daño = 0;
            }
            personaje.VidaActual -= daño;
            if(personaje.VidaActual<=0)
            {
                personaje.VidaActual=0;
                personaje.IsDead=true;
            }
            Console.WriteLine($"{Nombre} ha atacado a {personaje.Nombre}, le ha causado {daño} puntos de daño y la vida de {personaje.Nombre} es ahora {personaje.VidaActual}");
        }
        public int CalcularAtaque()
        {
            AtaqueTotal = Ataque;
            foreach(IItems item in listaItemsNoMagicos)
            {
                AtaqueTotal += item.Ataque;
            }
            if(this.ControlaMagia)
            {
                foreach(IItems item in listaItemsMagicos)
                {
                    AtaqueTotal += item.Ataque;
                }
            }
            return AtaqueTotal;
        }
        public int CalcularDefensa()
        {
            DefensaTotal = Defensa;
            foreach(IItems item in listaItemsNoMagicos)
            {
                DefensaTotal += item.Defensa;
            }
            if(this.ControlaMagia)
            {
                foreach(IItems item in listaItemsMagicos)
                {
                    DefensaTotal += item.Defensa;
                }
            }
            return DefensaTotal;
        }
        public void Curar()
        {
            int Curacion = 0;
            foreach(IItems item in listaItemsNoMagicos)
            {
                Curacion += item.Curacion;
            }
            if(this.ControlaMagia)
            {
                foreach(IItems item in listaItemsMagicos)
                {
                    Curacion += item.Curacion;
                }
            }
            if(VidaActual+Curacion>=VidaMaxima)
            {
                VidaActual = VidaMaxima;
            }
            else
            {
                VidaActual += Curacion;
            }
        }
        public void AgregarObjetos(IItems item)
        {
            if(item.EsMagico)
            {
                listaItemsMagicos.Add(item);
            }
            else
            {
                listaItemsNoMagicos.Add(item);
            }
        }
        public void EliminarObjetos(IItems item)
        {
            if(item.EsMagico)
            {
                bool contiene = this.listaItemsMagicos.Remove(item);
                if(contiene==false)
                {
                   throw new QuitarItemException("No se puede quitar un item que no se posee.");
                }
            }
            else
            {
                bool contiene = this.listaItemsNoMagicos.Remove(item);
                if(contiene==false)
                {
                   throw new QuitarItemException("No se puede quitar un item que no se posee.");
                }
            }
        }
        public void Intercambiar(Personaje personaje, IItems item)
        {
            if(item.EsMagico)
            {
                bool contiene = listaItemsMagicos.Remove(item);
                if(contiene==false)
                {
                    throw new QuitarItemException("No se puede intercambiar un item que no se posee.");
                }
                personaje.listaItemsMagicos.Add(item);
            }
            else
            {
                bool contiene = listaItemsNoMagicos.Remove(item);
                if(contiene==false)
                {
                    throw new QuitarItemException("No se puede intercambiar un item que no se posee.");
                }
                personaje.listaItemsNoMagicos.Add(item);
            }        
        }
    }
}