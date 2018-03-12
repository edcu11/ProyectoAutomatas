using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutomatasNFAYDFA
{
    public class Transicion
    {
        public Transicion(char key, Estado nextState)
        {
            Key = key;
            NextState = nextState;
        }

        public char Key { get; set; }
        public Estado NextState { get; set; }

    }

    public class Estado
    {
        public List<Transicion> transiciones{ get; set; }
        public string Nombre { get; set; }
        public bool EstadoInicial { get; set; }
        public bool EstadoDeAceptacion { get; set; }

        public Estado()
        {
            transiciones = new List<Transicion>();
        }

        public Estado(string nombre, bool estadoInicial, bool estadoDeAceptacion) : this()
        {
            Nombre = nombre;
            EstadoInicial = estadoInicial;
            EstadoDeAceptacion = estadoDeAceptacion;
        }

        public void AddTransition(Estado estado, char symbol)
        {
            transiciones.Add(new Transicion(symbol, estado));
        }

        public bool ContainsDuplicateTransition()
        {
            foreach (var transicion in transiciones)
            {
                var subTransiciones = GetTransitionsWithKey(transicion.Key);
                if (subTransiciones.Count() > 1)
                    return true;
            }

            return false;
        }

        public IEnumerable<Transicion> GetTransitionsWithKey(char transitionKey)
        {
            return transiciones.Where(x => x.Key == transitionKey);
        }

        internal IEnumerable<char> GetKeys()
        {
            List<char> keys = new List<char>();
            foreach (var transicion in transiciones)
            {
                keys.Add(transicion.Key);
            }

            return keys.AsEnumerable();
        }

        public IEnumerable<Estado> GetWaysWith(char key)
        {
            var transicionesConKey = GetTransitionsWithKey(key);
            List<Estado> estados = new List<Estado>();

            foreach (var trans in transicionesConKey)
            {
                estados.Add(trans.NextState);
            }

            return estados.AsEnumerable();
             
        }
    }
}