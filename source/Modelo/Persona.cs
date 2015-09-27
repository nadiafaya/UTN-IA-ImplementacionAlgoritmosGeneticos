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
            return name.ToString() + " es " + nationality.ToString() + ", y " + mouthAction.ToString() + " en su " + vehicle.ToString();
        }
    }
}
