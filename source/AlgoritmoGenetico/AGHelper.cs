using System;
using System.Collections.Generic;
using GAF;
using GAF.Operators;
using Modelo;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace AlgoritmoGenetico
{
    public class AGHelper
    {
        const int porcentajeInicialDeElitismo = 5;
        const double probabilidadDeCrossOver = 0.8;
        static public double probabilidadDeMutacion = 0.12;
        const int longitudDelCromosoma = 45;
        private Stopwatch reloj = new Stopwatch();
        static public int fitnessRequerido = 1200;
        static public int cantidadDeIteraciones = 1000;
        double mejorFitness = -1;
        private Logger logger;
        private List<DataPoint> puntos = new List<DataPoint>();
        private GeneticAlgorithm ga;

        private static AGHelper _instance;
        public static AGHelper getInstance()
        {
            if (_instance == null)
            {
                _instance = new AGHelper();
            }
            return _instance;
        }
        private static int _cantidadDePoblacion = 100;
        public static int cantidadDePoblacion
        {
            get { return _cantidadDePoblacion; }
            set { _cantidadDePoblacion = value; }
        }

        public IGeneticOperator SelectionOperator
        {
            get;
            set;
        }

        private List<GeneticOperator> _selectionOperators;
        public List<GeneticOperator> SelectionOperators
        {
            get { return _selectionOperators; }
            set { _selectionOperators = value; }
        }

        private List<GeneticOperator> _crossOperators;
        public List<GeneticOperator> CrossOperators
        {
            get { return _crossOperators; }
            set { _crossOperators = value; }
        }

        private List<GeneticOperator> _mutationOperators;
        public List<GeneticOperator> MutationOperators
        {
            get { return _mutationOperators; }
            set { _mutationOperators = value; }
        }

        public IGeneticOperator CrossOperator
        {
            get;
            set;
        }

        public IGeneticOperator MutationOperator
        {
            get;
            set;
        }

        public Action<GaEventArgs> OnRunCompleteCallback;
        public Action<GaEventArgs> OnGenerationCompleteCallback;

        public AGHelper()
        {
            logger = Logger.Instance;
            reloj.Start();

            // create selection operators
            _selectionOperators = new List<GeneticOperator>() {
                new GeneticOperator()
                {
                    Name = "Torneo (Elitismo)",
                    Operator = new Elite(porcentajeInicialDeElitismo)
                }
            };

            // create cross operators

            _crossOperators = new List<GeneticOperator>() {
                new GeneticOperator()
                {
                    Name = "Simple",
                    Operator = new Crossover(probabilidadDeCrossOver)
                    {
                        CrossoverType = CrossoverType.SinglePoint
                    }
                },
                new GeneticOperator()
                {
                    Name="Doble",
                    Operator = new Crossover(probabilidadDeCrossOver)
                    {
                        CrossoverType = CrossoverType.DoublePoint
                    }
                },
                new GeneticOperator()
                {
                    Name="Doble Ordenada",
                    Operator= new Crossover(probabilidadDeCrossOver)
                    {
                        CrossoverType = CrossoverType.DoublePointOrdered
                    }
                }
            };

            // create mutation operators
            _mutationOperators = new List<GeneticOperator>() {
                new GeneticOperator()
                {
                    Name = "Simple",
                    Operator = new BinaryMutate(mutationProbability: probabilidadDeMutacion, allowDuplicates: true)
                },
                new GeneticOperator()
                {
                    Name= "Intercambiada",
                    Operator = new SwapMutate(mutationProbability: probabilidadDeMutacion)
                }
            };
        }

        public void Run()
        {
            //create the GA
            ga = new GeneticAlgorithm(CreatePopulation(), CalcularFitness);
            //hook up to some useful events
            ga.OnGenerationComplete += ga_OnGenerationComplete;
            ga.OnRunComplete += ga_OnRunComplete;
            //add the operators
            ga.Operators.Add(SelectionOperator);
            ga.Operators.Add(CrossOperator);
            ga.Operators.Add(MutationOperator);

            ga.Run(FinalizarAG);
        }

        private Population CreatePopulation()
        {
            return new Population(populationSize: _cantidadDePoblacion,
                    chromosomeLength: longitudDelCromosoma,
                    reEvaluateAll: true,
                    useLinearlyNormalisedFitness: true,
                    selectionMethod: ParentSelectionMethod.FitnessProportionateSelection);
        }

        void ga_OnRunComplete(object sender, GaEventArgs e)
        {
            reloj.Stop();
            if (OnRunCompleteCallback != null)
            {
                OnRunCompleteCallback(e);
            }
        }

        private void ga_OnGenerationComplete(object sender, GaEventArgs e)
        {
            var fittest = e.Population.GetTop(1)[0];
            asignarMejorPoblacion(e);
            if (OnGenerationCompleteCallback != null)
            {
                OnGenerationCompleteCallback(e);
            }
        }

        private void asignarMejorPoblacion(GaEventArgs e)
        {
            Chromosome cromo = e.Population.Solutions.Find(x => x.Fitness == e.Population.MaximumFitness);
            if (cromo.Fitness > mejorFitness)
            {
                mejorFitness = cromo.Fitness;
                logger.asignarMejorSolucion(cromo, e.Generation, e.Evaluations);
            }
        }

        public static double CalcularFitness(Chromosome cromosoma)
        {
            double valorFitness = -1;
            //var distanceToTravel = CalculateDistance(chromosome);
            //return 1 - distanceToTravel / 10000;
            if (cromosoma != null)
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

        public bool FinalizarAG(Population Poblacion, int GeneracionActual, long EvaluacionActual)
        {
            return Poblacion.MaximumFitness >= fitnessRequerido || GeneracionActual == cantidadDeIteraciones;
        }

        public void UpdateElitismOptions(int porcentajeDeElitismo)
        {
            ((Elite)SelectionOperators[0].Operator).Percentage = porcentajeDeElitismo;
        }
    }
}
