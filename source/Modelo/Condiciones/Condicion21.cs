using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Condiciones
{
    class Condicion21 : ICondition
    {
        public double valueFromPersona(Persona persona)
        {
            double retorno = Valores.INVALIDO;
            if (persona.Nationality.Equals(Nationality.Aleman) && persona.Vehicle.Equals(Vehicle.Auto))
            {
                retorno = Valores.VALIDO;
            }
            return retorno;
        }
    }
}
