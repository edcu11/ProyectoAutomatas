using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatasNFAYDFA
{
    public class ConverterToDFA
    {
        Automata dfaEquivalent;
        Automata oldAutomata;
        List<char> language;
        public ConverterToDFA()
        {
            dfaEquivalent = new Automata();
            oldAutomata = new Automata();
            language = new List<char>();
        }

        internal Automata GetDFAEquivalentFromNFA(Automata automata)
        {
            dfaEquivalent = new Automata();
            oldAutomata = automata;
            var estadoInicial = automata.GetInitialState();
            language = automata.GetLanguage();

            ArmarDFA(estadoInicial);
            ActualizarTransiciones(); //disculpe mi chabacanada inge plis


            return dfaEquivalent;

        }

        private void ActualizarTransiciones()
        {
            foreach (var estado in dfaEquivalent.Estados)
            {
                foreach (var trans in estado.transiciones)
                {
                    trans.NextState = dfaEquivalent.EstadoConNombre(trans.NextState.Nombre);
                }
            }

        }

        private void ArmarDFA(Estado estadoInicial)
        {
            List<Estado> nuevosEstados = new List<Estado>();
            string nombreDeEstado = string.Empty;
            IEnumerable<Estado> estadosCompositores;
            IEnumerable<Estado> caminos;

            Estado estadoResultado = new Estado(estadoInicial.Nombre, estadoInicial.EstadoInicial, estadoInicial.EstadoDeAceptacion);


            foreach (var symbol in language)
            {
                //estados que componen este estado en el dfa (q0,q1). nombre de nuevo estado, osea row q0,q1
                estadosCompositores = ObtenerEstadosDeEstadoCompuesto(estadoInicial, symbol);
                //los caminos a los que voy de los estados que tengo, con symbol. lo que esta en la table en columna "a" p.e
                caminos = ObtenerCaminosDeEstados(estadosCompositores, symbol);
                if (caminos.Count() < 1)
                    continue;
                nombreDeEstado = DeterminarNombreDeNuevoEstado(caminos);
                var esInicial = ContainsInitialState(caminos);
                var esFinal = ContainsFinalState(caminos);
                estadoResultado.AddTransition(ObtenerNuevoEstadoExistente(nombreDeEstado, esInicial, esFinal), symbol);
            }

            AddDFAState(estadoResultado);
            ArmarNuevosEstados(estadoResultado);

        }

        private void ArmarNuevosEstados(Estado estadoResultado)
        {
            foreach (var trans in estadoResultado.transiciones)
            {
                if (!dfaEquivalent.ContainsState(trans.NextState))
                {
                    ArmarDFA(trans.NextState);
                }
            }
        }

        private IEnumerable<Estado> ObtenerEstadosDeEstadoCompuesto(Estado estadoInicial, char symbol)
        {
            var nombresDeEstados = estadoInicial.Nombre.Split(',').ToList();
            List<Estado> estados = new List<Estado>();

            foreach (var nombre in nombresDeEstados)
            {
                estados.Add(oldAutomata.EstadoConNombre(nombre));
            }

            return estados;
        }

        private Estado ObtenerNuevoEstadoExistente(string nombreDeEstado, bool esInicial, bool esFinal)
        {
            var estado = dfaEquivalent.EstadoConNombre(nombreDeEstado);
            if(estado == null)
                estado = new Estado(nombreDeEstado, esInicial, esFinal);
            return estado;
        }

        private IEnumerable<Estado> ObtenerCaminosDeEstados(IEnumerable<Estado> estados, char symbol)
        {
            List<Estado> estadosDestino = new List<Estado>();
            foreach (var estado in estados)
            {
                estadosDestino.AddRange(estado.GetWaysWith(symbol));
            }

            return estadosDestino.Distinct();
        }


        private string DeterminarNombreDeNuevoEstado(IEnumerable<Estado> estados)
        {
            string nombre = string.Empty;

            foreach (var estado in estados)
            {
                nombre += estado.Nombre;
                nombre += ",";
            }

            nombre = nombre.Remove(nombre.LastIndexOf(','));
            return nombre;

        }

        private bool ContainsInitialState(IEnumerable<Estado> estados)
        {
            if (dfaEquivalent.GetInitialState() == null)
                return true;
            return false;

        }

        private bool ContainsFinalState(IEnumerable<Estado> estados)
        {
            return estados.ToList().Find(x => x.EstadoDeAceptacion) != null;
        }


        private void AddDFAState(Estado estado)
        {
            if (!dfaEquivalent.ContainsState(estado))
                dfaEquivalent.Estados.Add(estado);
        }
    }
}
