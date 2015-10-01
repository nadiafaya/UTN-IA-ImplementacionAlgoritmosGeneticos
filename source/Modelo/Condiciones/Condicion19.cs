using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Condiciones
{
    class Condicion19 : ICondition
    {
        public double valueFromPersona(Persona persona)
        {
            double retorno = Valores.INVALIDO;
            if (persona.MouthAction.Equals(MouthAction.Tararea) && persona.Vehicle.Equals(Vehicle.Bicicleta))
            {
                retorno = Valores.VALIDO;
            }
            return retorno;
        }
    }
}
