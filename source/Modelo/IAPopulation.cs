using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAF;

namespace Modelo
{
    public class IAPopulation : Population
    {
        public IAPopulation(int size) : base()
        {
            for (var p = 0; p < size; p++)
            {
                var chromosome = new Chromosome();
                for (var g = 0; g < 4; g++)
                {
                    chromosome.Genes.Add(new Gene(new Random().Next(0, 7)));
                }
                Solutions.Add(chromosome);

            }
        }
    }
}
