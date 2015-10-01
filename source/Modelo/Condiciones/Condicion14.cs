﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Condiciones
{
    class Condicion14 : ICondition
    {
        public double valueFromPersona(Persona persona)
        {
            double retorno = Valores.INVALIDO;
            if (persona.Nationality.Equals(Nationality.Turco) && !persona.MouthAction.Equals(MouthAction.Maldice))
            {
                retorno = Valores.VALIDO;
            }
            return retorno;
        }
    }
}
