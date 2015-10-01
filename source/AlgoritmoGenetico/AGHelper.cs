using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAF;
using GAF.Operators;
using Modelo;

namespace AlgoritmoGenetico
{
    public class AGHelper
    {
        private static AGHelper _instance;
        public static AGHelper getInstance()
        {
            if (_instance == null)
            {
                _instance = new AGHelper();
            }
            return _instance;
        }
        private static int _populationSize = 2;
        public static int populationSize
        {
            get { return _populationSize; }
            set { _populationSize = value; }
        }
        const int porcentajeDeElitismo = 5;
        const double probabilidadDeCrossOver = 0.8;
        const double probabilidadDeMutacion = 0.02;
        const int longitudDelCromosoma = 45;
        private CrossoverType _TipoDeCrossOver = CrossoverType.SinglePoint;

        public AGHelper()
        {
            //var population = new IAPopulation(40);
            var poblacion = new Population(_populationSize, longitudDelCromosoma, true, true, ParentSelectionMethod.FitnessProportionateSelection);
            //create the elite operator
            var elite = new Elite(porcentajeDeElitismo);

            //create the crossover operator
            var crossover = new Crossover(probabilidadDeCrossOver)
            {
                CrossoverType = _TipoDeCrossOver
            };

            //create the mutation operator
            var mutacion = new SwapMutate(probabilidadDeMutacion);

            //create the GA
            var ga = new GeneticAlgorithm(poblacion, CalcularFitness);

            //hook up to some useful events
            ga.OnGenerationComplete += ga_OnGenerationComplete;
            ga.OnRunComplete += ga_OnRunComplete;

            //add the operators
            ga.Operators.Add(elite);
            ga.Operators.Add(crossover);
            ga.Operators.Add(mutacion);

            ga.Run(FinalizarAG);
        }

        static void ga_OnRunComplete(object sender, GaEventArgs e)
        {
            //var fittest = e.Population.GetTop(1)[0];
            //foreach (var gene in fittest.Genes)
            //{
            //    Console.WriteLine(_cities[(int)gene.RealValue].Name);
            //}
        }

        private static void ga_OnGenerationComplete(object sender, GaEventArgs e)
        {
            //var fittest = e.Population.GetTop(1)[0];
            //var distanceToTravel = CalculateDistance(fittest);
            //Console.WriteLine("Generation: {0}, Fitness: {1}, Distance: {2}", e.Generation, fittest.Fitness, distanceToTravel);
        }

        public static double CalcularFitness(Chromosome cromosoma)
        {
            double valorFitness = -1;
            //var distanceToTravel = CalculateDistance(chromosome);
            //return 1 - distanceToTravel / 10000;
            if(cromosoma != null)
            {
                if (cromosoma.Count.Equals(longitudDelCromosoma))
                {
                    valorFitness = Acertijo.Instance.FitnessFunction(cromosoma);
                }
                else
                {
                    throw new ApplicationException("La longitud del cromosoma es incorrecta.");
                }

            }
            else
            {
                throw new ArgumentNullException("cromosoma", "El cromosoma especificado es null.");
            }
            return valorFitness;
        }

        public static bool FinalizarAG(Population Poblacion,
        int GeneracionActual, long EvaluacionActual)
        {
            return GeneracionActual > 1000;
        }
    }
}
