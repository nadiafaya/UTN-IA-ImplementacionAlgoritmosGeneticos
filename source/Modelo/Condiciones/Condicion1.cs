using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Condiciones
{
    public class Condicion1:ICondition
    {
        public double valueFromPersona(Persona persona)
        {
            double retorno = Valores.INVALIDO;
            if(persona.MouthAction.Equals(MouthAction.Silba) && !persona.Nationality.Equals(Nationality.Griego))
            {
                retorno = Valores.VALIDO;
            }
            return retorno;
        }
    }
}