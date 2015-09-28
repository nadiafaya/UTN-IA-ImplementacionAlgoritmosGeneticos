using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Condiciones
{
    class Condicion12 : ICondition
    {
        public double valueFromPersona(Persona persona)
        {
            double retorno = -10;
            if (persona.Vehicle.Equals(Vehicle.Moto) && persona.Nationality.Equals(Nationality.Turco))
            {
                retorno = 50;
            }
            return retorno;
        }
    }
}
