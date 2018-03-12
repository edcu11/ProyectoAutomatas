using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatasNFAYDFA
{
    public partial class EvualetorForm : MetroFramework.Forms.MetroForm
    {
        Automata automata;
        ConverterToDFA converter;
        public EvualetorForm(Automata auto)
        {
            InitializeComponent();
            automata = auto;
            converter = new ConverterToDFA();
            FormatResultView();

        }

        private void FormatResultView()
        {
            resultsView.View = View.Details;
            resultsView.Columns.Add("Accepted Columns");
            resultsView.Columns[0].Width = -2;
        }

        private void EvualetorForm_Load(object sender, EventArgs e)
        {


        }

        private void CheckFile_Click(object sender, EventArgs e)
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var cadenas = File.ReadAllLines(path + "\\Resources\\" + FileNameTxt.Text).ToList();

            if (automata.SoyNFA())
            {
                automata = converter.GetDFAEquivalentFromNFA(automata);
            }

            foreach (var cadena in cadenas)
            {
                automata.Evaluar(cadena);
            }

            AgregarCadenasAceptadasAResultView();

        }

        private void AgregarCadenasAceptadasAResultView()
        {
            resultsView.Items.Clear();
            foreach (var cadenaAceptada in automata.CadenasAcceptadas)
            {
                resultsView.Items.Add(new ListViewItem(cadenaAceptada));
            }
        }
    }
}
