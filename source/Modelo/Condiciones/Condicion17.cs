﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Condiciones
{
    class Condicion17 : ICondition
    {
        public double valueFromPersona(Persona persona)
        {
            double retorno = Valores.INVALIDO;
            if (persona.Name.Equals(Name.Baltasar) && persona.Vehicle.Equals(Vehicle.Moto))
            {
                retorno = Valores.VALIDO;
            }
            return retorno;
        }
    }
}
