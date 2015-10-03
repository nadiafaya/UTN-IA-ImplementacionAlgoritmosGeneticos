using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Condiciones
{
    class Condicion9 : ICondition
    {
        public double valueFromPersona(List<Persona> personas)
        {
            double retorno = (double)Valores.INVALIDO;
            if (personas.FindAll(persona => persona.Nationality.Equals(Nationality.Finlandes) && !persona.MouthAction.Equals(MouthAction.Canta))
                        .Count > 0)
            {
                retorno = (double)Valores.VALIDO;
            }
            return retorno;
        }
    }
}
