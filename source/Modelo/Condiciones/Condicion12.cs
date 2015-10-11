using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Condiciones
{
    class Condicion12 : ICondition
    {
        public double valueFromPersona(List<Persona> personas)
        {
            double retorno = (double)Valores.INVALIDO;
            if (personas.FindAll(persona => persona.Vehicle.Equals(Vehicle.Moto) && persona.Nationality.Equals(Nationality.Turco))
                .Count > 0 && personas.FindAll(persona => persona.Vehicle.Equals(Vehicle.Moto)).Count==1)
            {
                retorno = (double)Valores.VALIDO;
            }
            return retorno;
        }
    }
}
