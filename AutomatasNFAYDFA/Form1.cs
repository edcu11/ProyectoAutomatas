using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatasNFAYDFA
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        List<char> language;
        Automata automata;
        public Form1()
        {
            InitializeComponent();
            FormatearTablas();
            language = new List<char>();
            automata = new Automata();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FormatearTablas()
        {
            AgregarColumnas();
            FormatearColumnas();
        }

        private void FormatearColumnas()
        {
            tablaDeEstados.View = View.Details;
            SymbolsTable.View = View.Details;
        }

        private void AgregarColumnas()
        {
            SymbolsTable.Columns.Add("Symbols");
            tablaDeEstados.Columns.Add("Estado");
        }

        private void StartForm(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
            this.Activate();
        }


        private void symbolTxt_Enter(object sender, EventArgs e)
        {
            symbolTxt.Text = "";
        }

        #region AGREGAR SIMBOLLO

        private void AddSymbolBtn_Click(object sender, EventArgs e)
        {
            var newSymbol = symbolTxt.Text;

            if (!IsSymbolValid(newSymbol))
                return;

            language.Add(newSymbol[0]);
            AddNewSymbolTable(newSymbol);

        }

        private bool IsSymbolValid(string newSymbol)
        {
            if (newSymbol.Length != 1)
            {
                MessageBox.Show("Simbolo debe ser de un solo caracter!");
                return false;
            }

            if (language.Contains(newSymbol[0]))
            {
                MessageBox.Show("Simbolo ya existe!");
                return false;
            }

            return true;

        }

        private void AddNewSymbolTable(string newSymbol)
        {
            SymbolsTable.Items.Add(new ListViewItem(newSymbol));
            SymbolsTable.Columns[0].Width = -2;
            SymbolsCb.Items.Add(newSymbol);
            tablaDeEstados.Columns.Add(newSymbol);
        }


        #endregion

        #region AGREGAR ESTADO

        private void AddStateBtn_Click(object sender, EventArgs e)
        {
            if (!IsValidState(stateNameTxt.Text))
                return;

            var newState = new Estado(stateNameTxt.Text, IsInitial.Checked, IsAcceptable.Checked);
            string formattedStateName = CreateStateString(newState);
            List<string> row = new List<string>();
            row.Add(formattedStateName);
            InitEmptyFields(row);
            tablaDeEstados.Items.Add(new ListViewItem(row.ToArray()));
            stateToCB.Items.Add(newState.Nombre);
            stateFromCB.Items.Add(newState.Nombre);
            DisableInitialBtn();

            automata.Estados.Add(newState);
        }

        private void InitEmptyFields(List<string> row)
        {
            for (int i = 0; i < tablaDeEstados.Columns.Count - 1; i++)
            {
                row.Add(string.Empty);
            }
        }

        private bool IsValidState(string stateName)
        {
            if (StateTableContains(stateName))
            {
                MessageBox.Show("Estado ya existe!");
                return false;
            }

            return true;
        }

        private bool StateTableContains(string stateName)
        {
            for (int i = 0; i < tablaDeEstados.Items.Count; i++)
            {
                string selectedItemText = ObtenerNombreDeEstadoReal(i);
                if (selectedItemText.Equals(stateName))
                    return true;
            }
            return false;
        }

        private string ObtenerNombreDeEstadoReal(int i)
        {
            var selectedItemText = tablaDeEstados.Items[i].SubItems[0].Text;
            selectedItemText = selectedItemText.Replace("->", "");
            selectedItemText = selectedItemText.Replace("*", "");
            return selectedItemText;
        }

        private void DisableInitialBtn()
        {
            if (!IsInitial.Checked)
                return;

            IsInitial.Checked = false;
            IsInitial.Enabled = false;
        }

        private string CreateStateString(Estado newState)
        {
            var tableStateText = (newState.EstadoInicial) ? "->" : "";
            tableStateText += newState.Nombre;
            tableStateText += (newState.EstadoDeAceptacion) ? "*" : "";
            return tableStateText;
        }

        #endregion

        #region AGREGAR TRANSICION

        private void AddTransitionBtn_Click(object sender, EventArgs e)
        {
            var symbolName = SymbolsCb.Text;
            var stateFrom = stateFromCB.Text;
            var stateTo = stateToCB.Text;

            if (!IsValidTransition(symbolName, stateTo, stateFrom))
                return;

            int columnIndex = GetSymbolIndex(symbolName);
            ListViewItem row = GetStateRow(stateFrom);
            if (!row.SubItems[columnIndex].Text.Contains(stateTo))
                row.SubItems[columnIndex].Text += "/" + stateTo;

            var ida = automata.Estados.Find(x => x.Nombre.Equals(stateFrom));
            var venida = automata.Estados.Find(x => x.Nombre.Equals(stateTo));
            ida.AddTransition(venida, symbolName[0]);

        }

        private ListViewItem GetStateRow(string stateFrom)
        {
            var nombreReal = "";
            for (int i = 0; i < tablaDeEstados.Items.Count; i++)
            {
                nombreReal = ObtenerNombreDeEstadoReal(i);
                if (nombreReal.Equals(stateFrom))
                    return tablaDeEstados.Items[i];
            }
            return null;
        }

        private int GetSymbolIndex(string symbolName)
        {
            for (int i = 0; i < tablaDeEstados.Columns.Count; i++)
            {
                if (tablaDeEstados.Columns[i].Text.Equals(symbolName))
                {
                    return i;
                }
            }

            return -1;
        }

        private bool IsValidTransition(string symbolName, string stateTo, string stateFrom)
        {
            if (symbolName.Equals(string.Empty) || stateTo.Equals(string.Empty) || stateFrom.Equals(string.Empty))
            {
                MessageBox.Show("Eliga valores no nulos");
                return false;
            }

            return true;
        }

        #endregion

        private void Evaluar_Click(object sender, EventArgs e)
        {
            EvualetorForm form = new EvualetorForm(automata);
            StartForm(form);
        }
    }
}
