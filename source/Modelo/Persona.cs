using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAF;

namespace Modelo
{
    public class Persona 
    {
        Name name;
        Nationality nationality;
        MouthAction mouthAction;
        Vehicle vehicle;

        public override string ToString()
        {
            return string.Format("{0} es {1} y {2} en su {3}", name.ToString(), nationality.ToString(), mouthAction.ToString(), vehicle.ToString());
        }
    }
}
