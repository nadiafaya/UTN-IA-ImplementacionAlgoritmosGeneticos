using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Condiciones
{
    class Condicion24 : ICondition
    {
        public double valueFromPersona(Persona persona)
        {
            double retorno = Valores.INVALIDO;
            if (persona.Name.Equals(Name.Aquiles) && !persona.Nationality.Equals(Nationality.Griego))
            {
                retorno = Valores.VALIDO;
            }
            return retorno;
        }
    }
}
