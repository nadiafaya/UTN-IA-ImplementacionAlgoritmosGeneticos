using AlgoritmoGenetico;
using GAF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UI
{
    public partial class MainForm : Form
    {
        private AGHelper agInstance;

        public MainForm()
        {
            InitializeComponent();
            agInstance = AGHelper.getInstance();
            agInstance.OnGenerationCompleteCallback = OnGenerationComplete;
            agInstance.OnRunCompleteCallback= OnRunComplete;
            LoadGeneticOperatorsControls();
        }

        private void LoadGeneticOperatorsControls()
        {
            LoadGeneticOperatorsIntoControl(agInstance.SelectionOperators, selectionComboBox);
            LoadGeneticOperatorsIntoControl(agInstance.CrossOperators, crossComboBox);
            LoadGeneticOperatorsIntoControl(agInstance.MutationOperators, mutationComboBox);
        }

        private void LoadGeneticOperatorsIntoControl(List<GeneticOperator> geneticOperators, ComboBox control)
        {
            control.Items.AddRange(geneticOperators.Cast<object>().ToArray());
            
            control.SelectedIndex = 0;
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            EjecutarGAF();
        }

        private void EjecutarGAF()
        {
            LoadAGWithSelectedOperators();
            tabControl.SelectTab(resultsPage);
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

        private void SelectionOperatorChanged(object sender, EventArgs e)
        {
            elitismOptions.Visible = selectionComboBox.SelectedIndex == 0;
        }

        private void ElitismOptionsChanged(object sender, EventArgs e)
        {
            agInstance.UpdateElitismOptions((int)elitismPercentage.Value);
        }

        private void OnRunComplete(GaEventArgs e)
        {
            chart.Show();
        }

        private void OnGenerationComplete(GaEventArgs e)
        {
            var point = new DataPoint(e.Generation, e.Population.MaximumFitness);
            chart.Series[0].Points.AddXY(point.XValue, point.YValues[0]);
            
        }
    }
}
