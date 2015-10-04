using GAF;

namespace AlgoritmoGenetico
{
    public class GeneticOperator
    {
        public string Name { get; set; }
        public IGeneticOperator Operator { get; set; }
    }
}
