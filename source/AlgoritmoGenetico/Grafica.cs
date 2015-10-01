﻿using System;
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
    public partial class Grafica : Form
    {
      
        public Grafica(List<DataPoint> puntos)
        {
            InitializeComponent();
            CargarPuntos(puntos);
        }

        private void CargarPuntos(List<DataPoint> puntos)
        {
            puntos.ForEach(x => chart.Series[0].Points.AddXY(x.XValue, x.YValues[0]));
        }
    }
}
