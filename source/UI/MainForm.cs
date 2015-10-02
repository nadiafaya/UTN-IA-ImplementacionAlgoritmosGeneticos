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
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            EjecutarGAF();
        }

        private void EjecutarGAF()
        {
            agInstance.Run();
        }
    }
}
