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

        public AGHelper()
        {
            var population = new IAPopulation(40);
            //create the elite operator
            var elite = new Elite(5);

            //create the crossover operator
            var crossover = new Crossover(0.8)
            {
                CrossoverType = CrossoverType.SinglePoint
            };

            //create the mutation operator
            var mutate = new SwapMutate(0.02);

            //create the GA
            var ga = new GeneticAlgorithm(population, CalculateFitness);

            //hook up to some useful events
            ga.OnGenerationComplete += ga_OnGenerationComplete;
            ga.OnRunComplete += ga_OnRunComplete;

            //add the operators
            ga.Operators.Add(elite);
            ga.Operators.Add(crossover);
            ga.Operators.Add(mutate);
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

        public static double CalculateFitness(Chromosome chromosome)
        {
            //var distanceToTravel = CalculateDistance(chromosome);
            //return 1 - distanceToTravel / 10000;
            return 0.0;
        }
    }
}
