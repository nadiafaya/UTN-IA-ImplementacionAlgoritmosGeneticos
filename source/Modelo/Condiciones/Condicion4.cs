using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Condiciones
{
    class Condicion4 : ICondition
    {
        public double valueFromPersona(Persona persona)
        {
            double retorno = Valores.INVALIDO;
            if (persona.Name.Equals(Name.Gregorio) && !persona.Vehicle.Equals(Vehicle.Camion))
            {
                retorno = Valores.VALIDO;
            }
            return retorno;
        }
    }
}
