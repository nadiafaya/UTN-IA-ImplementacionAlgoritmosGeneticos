using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Condiciones
{
    class Condicion2 : ICondition
    {
        public double valueFromPersona(Persona persona)
        {
            double retorno = Valores.INVALIDO;
            if (persona.Nationality.Equals(Nationality.Griego) && !persona.Name.Equals(Name.Cosme))
            {
                retorno = Valores.VALIDO;
            }
            return retorno;
        }
    }
}