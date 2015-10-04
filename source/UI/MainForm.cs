using AlgoritmoGenetico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MainForm : Form
    {
        private AGHelper agInstance;

        public MainForm()
        {
            InitializeComponent();
            agInstance = AGHelper.getInstance();
            LoadGeneticOperatorsControls();
        }

        private void LoadGeneticOperatorsControls()
        {
            var selectionOperators = agInstance.GetSelectionGeneticOperators();
            LoadGeneticOperatorsIntoControl(selectionOperators, selectionComboBox);
            var crossOperators = agInstance.GetCrossGeneticOperators();
            LoadGeneticOperatorsIntoControl(crossOperators, crossComboBox);
            var mutationOperators = agInstance.GetMutationGeneticOperators();
            LoadGeneticOperatorsIntoControl(mutationOperators, mutationComboBox);
        }

        private void LoadGeneticOperatorsIntoControl(List<GeneticOperator> geneticOperators, ComboBox control)
        {
            control.Items.AddRange(geneticOperators.Cast<object>().ToArray());
            control.ValueMember = null;
            control.DisplayMember = "Name";
            control.SelectedIndex = 0;
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            EjecutarGAF();
        }

        private void EjecutarGAF()
        {
            LoadAGWithSelectedOperators();
            agInstance.Run();
        }

        private void LoadAGWithSelectedOperators()
        {
            var selectedSelectionOperator = (GeneticOperator) selectionComboBox.SelectedItem;
            agInstance.SelectionOperator = selectedSelectionOperator.Operator;
            var selectedCrossOperator = (GeneticOperator) crossComboBox.SelectedItem;
            agInstance.CrossOperator = selectedCrossOperator.Operator;
            var selectedMutationOperator = (GeneticOperator) mutationComboBox.SelectedItem;
            agInstance.MutationOperator= selectedMutationOperator.Operator;
        }
    }
}
