using GAF;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmoGenetico
{
    public sealed class Logger
    {
        private static Logger instance = null;
        private RichTextBox box;
        public Chromosome mejorSolucion;
        public int mejorIteracion = 0;
        public long mejorGeneracion = 0;
        private Logger() { }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }
        public void setTextBox(RichTextBox consola)
        {
            this.box = consola;
        }

        internal void informarResultados(GaEventArgs e, long cantIteracionesMax)
        {
            Chromosome cromo;
            appendText(Color.Indigo, string.Format("Cantidad de individuos: {0}, Cantidad de iteraciones Máxima: {1}", e.Population.PopulationSize, cantIteracionesMax), true);
            appendText(Color.Brown, string.Format("El mayor valor de ajuste alcanzado por la población final: {0}", e.Population.MaximumFitness), true);
            appendText(Color.Red, string.Format("Número de iteración: {0}, Cantidad de cromosomas evaluados:", e.Generation, e.Evaluations), true);
            appendText(Color.BlueViolet, "Mejor solución de la población final:", true);
            cromo = e.Population.Solutions.Find(x => x.Fitness == e.Population.MaximumFitness);
            informarCromosoma(cromo);

            appendText(Color.BlueViolet, "Mejor solución de la corrida:", true);
            if (mejorIteracion != 0)
            {
                appendText(Color.Red, string.Format("Número de iteración: {0}, Cantidad de cromosomas evaluados: {1}", mejorIteracion, mejorGeneracion), true);
                informarCromosoma(mejorSolucion);
            }
            else appendText(Color.HotPink, "No hubo una mejor solucion durante la corrida", true);

            appendText(Color.BlueViolet, "Población de la solución:", true);

            foreach (Chromosome cromosoma in e.Population.Solutions)
            {
                informarCromosoma(cromosoma);
            }

        }

        private void informarCromosoma(Chromosome cromosoma)
        {
            appendText(Color.Black, string.Format("Aptitud: {0}", cromosoma.Fitness), true);
        }

        public void appendText(Color color, string text, bool EsNuevaLinea = false)
        {
            if (EsNuevaLinea)
            {
                text += Environment.NewLine;
            }

            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
