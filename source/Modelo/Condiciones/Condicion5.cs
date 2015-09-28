using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Condiciones
{
    class Condicion5 : ICondition
    {
        public double valueFromPersona(Persona persona)
        {
            double retorno = -10;
            if (persona.Name.Equals(Name.Gregorio) && !persona.Nationality.Equals(Nationality.Irlandes))
            {
                retorno = 50;
            }
            return retorno;
        }
    }
}
