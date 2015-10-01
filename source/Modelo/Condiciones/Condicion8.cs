using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Condiciones
{
    class Condicion8 : ICondition
    {
        public double valueFromPersona(Persona persona)
        {
            double retorno = Valores.INVALIDO;
            if (persona.Nationality.Equals(Nationality.Finlandes) && !persona.Name.Equals(Name.Aquiles))
            {
                retorno = Valores.VALIDO;
            }
            return retorno;
        }
    }
}
