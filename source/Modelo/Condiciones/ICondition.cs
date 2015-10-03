using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAF;

namespace Modelo.Condiciones
{
    public interface ICondition
    {
        double valueFromPersona(List<Persona> personas);
    }
}
