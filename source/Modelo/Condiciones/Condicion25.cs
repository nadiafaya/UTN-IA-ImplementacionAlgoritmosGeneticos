using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Condiciones
{
    class Condicion25 : ICondition
    {
        public double valueFromPersona(List<Persona> personas)
        {
            double retorno = (double)Valores.INVALIDO;
            if (personas.FindAll(persona => persona.Vehicle.Equals(Vehicle.Bicicleta) && persona.Nationality.Equals(Nationality.Finlandes))
                        .Count == 1)
            {
                retorno = (double)Valores.VALIDO;
            }
            return retorno;
        }
    }
}
