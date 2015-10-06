using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ResultsTab : UserControl
    {
        public ResultsTab()
        {
            InitializeComponent();
        }

        public void AddPoint(double xValue, double yValue)
        {
            chart.Series[0].Points.AddXY(xValue, yValue);
        }

        public void ShowChart()
        {
            chart.Show();
        }
    }
}
