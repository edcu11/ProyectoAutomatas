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
            return transiciones.Where(x => x.Key == transitionKey).ToList();
        }

        private IEnumerable<Transicion> GetTransitionsWithEpsilonAfterKey(List<Transicion> subTransiciones)
        {
            List<Transicion> transEpsilon = new List<Transicion>();

            foreach (var subTrans in subTransiciones)
            {
                if (subTrans.NextState.GetAbsoluteTransitions('e') != null)
                {
                    transEpsilon.AddRange(null);
                }
            }

            return transEpsilon;
        }

        private IEnumerable<Transicion> GetMyTransitionsWithEpsilonBeforeKey(char transitionKey)
        {
            List<Transicion> transEpsilon = new List<Transicion>();
            List<Transicion> transicionesConEpsilonInicial = this.GetTransitionsWithKey('e').ToList();

            foreach (var trans in transicionesConEpsilonInicial)
            {
                if (trans.NextState.GetTransitionsWithKey('e') != null)
                {
                    transEpsilon.AddRange(GetMyTransitionsWithEpsilonBeforeKey(transitionKey));
                }
                else if (trans.NextState.GetTransitionsWithKey(transitionKey) != null)
                {
                    transEpsilon.AddRange(trans.NextState.GetTransitionsWithKey(transitionKey));
                }
            }

            return transEpsilon;
        }
        
        internal IEnumerable<char> GetKeys()
        {
            List<char> keys = new List<char>();
            foreach (var transicion in transiciones)
                keys.Add(transicion.Key);
            return keys.AsEnumerable();
        }

        public IEnumerable<Estado> GetWaysWith(char key)
        {
            IEnumerable<Transicion> transicionesConKey = GetAbsoluteTransitions(key);
            List<Estado> estados = new List<Estado>();
            foreach (var trans in transicionesConKey)
                estados.Add(trans.NextState);
            return estados.AsEnumerable();
             
        }

        private IEnumerable<Transicion> GetAbsoluteTransitions(char key)
        {
            var subTransiciones = GetTransitionsWithKey(key).ToList();
            //subTransiciones.AddRange(GetTransitionsWithEpsilonAfterKey(subTransiciones));
            //subTransiciones.AddRange(GetMyTransitionsWithEpsilonBeforeKey(key));

            return subTransiciones;


        }
    }
}