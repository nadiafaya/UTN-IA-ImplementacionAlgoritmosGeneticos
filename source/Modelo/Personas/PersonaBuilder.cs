using System;

namespace Modelo.Personas
{
    [Serializable]
    class PersonaBuilder
    {
        private static PersonaBuilder instance;
        int Indice;
        string Nombre;
        string AccionConLaBoca;
        string Vehiculo;
        string Nacionalidad;

        private PersonaBuilder() { }

        public static PersonaBuilder Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PersonaBuilder();
                }
                return instance;
            }
        }

        public void configurar(int indice, string accionConLaBoca, string vehiculo, string nacionalidad, string nombre)
        {
            Indice = indice;
            AccionConLaBoca = accionConLaBoca;
            Vehiculo = vehiculo;
            Nacionalidad = nacionalidad;
            Nombre = nombre;
        }

        public Persona build()
        {
            //TODO Completar el parseo 
            var nombre = Convert.ToInt32(Nombre, 2);
            var nacionalidad = Convert.ToInt32(Nacionalidad, 2);
            var accionConLaBoca = Convert.ToInt32(AccionConLaBoca, 2);
            var vehiculo = Convert.ToInt32(Vehiculo,2);
            return new Persona((Name)nombre, (Nationality)nacionalidad, (MouthAction)accionConLaBoca, (Vehicle)vehiculo);
        }
    }
}
