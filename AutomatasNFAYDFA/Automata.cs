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
    public class Automata
    {
        public List<Estado> Estados { get; set; }
        public List<string> CadenasAcceptadas { get; set; }
        public string ValorEvaluado { get; set; }

        public Automata()
        {
            Estados = new List<Estado>();
            CadenasAcceptadas = new List<string>();
        }

        public bool Evaluar(string cadena)
        {
            Estado estadoInicial = GetInitialState();
            ValorEvaluado = cadena;
            Evaluar(cadena, estadoInicial);
            Console.WriteLine("wauww");
            return true;
        }

        public Estado GetInitialState()
        {
            return Estados.Find(x => x.EstadoInicial);
        }

        public Estado EstadoConNombre(string nombre)
        {
            return Estados.Where(x => x.Nombre.Equals(nombre)).ToList().FirstOrDefault();
        }

        public bool ContainsState(Estado estado)
        {
            return (this.EstadoConNombre(estado.Nombre) != null);
        }

        private bool Evaluar(string valor, Estado estadoActual)
        {

            if (valor.Length == 0)
            {
                if (estadoActual.EstadoDeAceptacion)
                {
                    CadenasAcceptadas.Add(ValorEvaluado);
                    return true;    
                }
                return false;
            }

            char entrada = valor[0];


            valor = valor.Remove(0, 1);
            var transiciones = estadoActual.GetTransitionsWithKey(entrada);


            foreach (var transicion in transiciones)
            {
                if (Evaluar(valor, transicion.NextState))
                    return true;
            }

            return false;
        }

      

        public bool SoyNFA()
        {

            foreach (var estado in Estados)
            {
                if (estado.ContainsDuplicateTransition())
                    return true;
            }
            return false;
        }

        public List<char> GetLanguage()
        {
            List<char> lang = new List<char>();
            foreach (var estado in Estados)
            {
                lang.AddRange(estado.GetKeys());
            }

            return lang.Distinct().ToList();
        }

    }
}