using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Condiciones
{
    class Condicion13 : ICondition
    {
        List<Int32> vehiculos = new List<int> { (Int32)MouthAction.Maldice, (Int32)MouthAction.Recita, (Int32)MouthAction.Silba };
        public double valueFromPersona(List<Persona> personas)
        {
            double retorno = (double)Valores.INVALIDO;
            if (personas.FindAll(persona => persona.Vehicle.Equals(Vehicle.Moto) && !vehiculos.Contains((Int32)persona.MouthAction))
                .Count > 0)
            {
                retorno = (double)Valores.VALIDO;
            }
            return retorno;
        }
    }
}
