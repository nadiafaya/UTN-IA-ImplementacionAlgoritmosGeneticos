using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Condiciones
{
    class Condicion14 : ICondition
    {
        public double valueFromPersona(List<Persona> personas)
        {
            double retorno = (double)Valores.INVALIDO;
            if (personas.FindAll(persona => persona.Nationality.Equals(Nationality.Turco) && !persona.MouthAction.Equals(MouthAction.Maldice))
                .Count > 0)
            {
                retorno = (double)Valores.VALIDO;
            }
            return retorno;
        }
    }
}
