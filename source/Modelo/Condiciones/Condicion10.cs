using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Condiciones
{
    class Condicion10 : ICondition
    {
        public double valueFromPersona(Persona persona)
        {
            double retorno = Valores.INVALIDO;
            if (persona.Name.Equals(Name.Saverio) && !persona.MouthAction.Equals(MouthAction.Canta))
            {
                retorno = Valores.VALIDO;
            }
            return retorno;
        }
    }
}
