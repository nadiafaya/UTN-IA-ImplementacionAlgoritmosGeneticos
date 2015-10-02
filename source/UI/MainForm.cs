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
        public MainForm()
        {
            InitializeComponent();
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            EjecutarGAF();
        }

        private void EjecutarGAF()
        {
            AGHelper ag = AGHelper.getInstance();
        }
    }
}
