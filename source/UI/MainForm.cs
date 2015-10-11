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
        private int resultsCount = 0;
        private TabPage currentResultsPage;
        private ResultsTab currentResultsTab;

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
            
            progressBar.Value = 1;
            groupBox1.Enabled = false;
            Iniciar.Enabled = false;
            CreateResultsTab();
            LoadAGWithSelectedOperators();
            agInstance.Run();
        }

        private void CreateResultsTab()
        {
            resultsCount += 1;
            currentResultsPage = new TabPage("Results " + resultsCount);
            currentResultsTab = new ResultsTab();
            currentResultsTab.Dock = DockStyle.Fill;
            currentResultsPage.Controls.Add(currentResultsTab);
            tabControl.TabPages.Add(currentResultsPage);
            tabControl.SelectTab(currentResultsPage);
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
            currentResultsTab.ShowChart(e);
            progressBar.Value = 0;
            groupBox1.Enabled = true;
            Iniciar.Enabled = true;
        }

        private void OnGenerationComplete(GaEventArgs e)
        {
            progressBar.Value = (int) (Decimal.Divide(e.Generation, AGHelper.cantidadDeIteraciones) * 100);
            currentResultsTab.AddPoint(e.Generation, e.Population.MaximumFitness);
            currentResultsTab.ShowChart(e);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            AGHelper.cantidadDeIteraciones = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            AGHelper.fitnessRequerido = (int)numericUpDown2.Value;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = AGHelper.cantidadDeIteraciones;
            numericUpDown2.Value = AGHelper.fitnessRequerido;
            numericUpDown3.Value = (Decimal)AGHelper.probabilidadDeMutacion;
        }
    }
}
