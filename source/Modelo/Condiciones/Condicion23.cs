using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Condiciones
{
    class Condicion23 : ICondition
    {
        public double valueFromPersona(Persona persona)
        {
            double retorno = -10;
            if (persona.Nationality.Equals(Nationality.Aleman) && !persona.MouthAction.Equals(MouthAction.Maldice))
            {
                retorno = 50;
            }
            return retorno;
        }
    }
}
