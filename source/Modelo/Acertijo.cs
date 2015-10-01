﻿using GAF;
using Modelo.Condiciones;
using Modelo.Personas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Modelo
{
    public class Acertijo
    {
        private static Acertijo instance;
        private List<ICondition> condiciones = new List<ICondition>();
        private int constanteDeFitness;
        const int valorDeInvalidos = -10;
        const int valorDeRepetidos = -10;
        private Acertijo()
        {
            AgregarCondiciones();
            constanteDeFitness = 10;
        }
        #region condiciones
        private void AgregarCondiciones()
        {
            condiciones.Add(new Condicion1());
            condiciones.Add(new Condicion2());
            condiciones.Add(new Condicion3());
            condiciones.Add(new Condicion4());
            condiciones.Add(new Condicion5());
            condiciones.Add(new Condicion6());
            condiciones.Add(new Condicion7());
            condiciones.Add(new Condicion8());
            condiciones.Add(new Condicion9());
            condiciones.Add(new Condicion10());
            condiciones.Add(new Condicion11());
            condiciones.Add(new Condicion12());
            condiciones.Add(new Condicion13());
            condiciones.Add(new Condicion14());
            condiciones.Add(new Condicion15());
            condiciones.Add(new Condicion16());
            condiciones.Add(new Condicion17());
            condiciones.Add(new Condicion18());
            condiciones.Add(new Condicion19());
            condiciones.Add(new Condicion20());
            condiciones.Add(new Condicion21());
            condiciones.Add(new Condicion22());
            condiciones.Add(new Condicion23());
            condiciones.Add(new Condicion24());
        }
        #endregion

        public static Acertijo Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Acertijo();
                }
                return instance;
            }
        }

        #region Validaciones
        private int validarInvalidos(List<Persona> modelos)
        {
            //valido que no tenga cadena de bits invalidas
            int valor =
                modelos.Count(persona => persona.MouthAction == MouthAction.INVALID5) +
                modelos.Count(persona => persona.Name == Name.INVALID5) +
                modelos.Count(persona => persona.Nationality == Nationality.INVALID5) +
                modelos.Count(persona => persona.Vehicle == Vehicle.INVALID5) +
                modelos.Count(persona => persona.MouthAction == MouthAction.INVALID6) +
                modelos.Count(persona => persona.Name == Name.INVALID6) +
                modelos.Count(persona => persona.Nationality == Nationality.INVALID6) +
                modelos.Count(persona => persona.Vehicle == Vehicle.INVALID6) +
                modelos.Count(persona => persona.MouthAction == MouthAction.INVALID7) +
                modelos.Count(persona => persona.Name == Name.INVALID7) +
                modelos.Count(persona => persona.Nationality == Nationality.INVALID7) +
                modelos.Count(persona => persona.Vehicle == Vehicle.INVALID7);
            return valor * valorDeInvalidos;
        }

        private int ValidadNombresRepetidos(List<Persona> personas)
        {
            Name nombre;
            int valor = 0;
            foreach (Persona persona in personas)
            {
                nombre = persona.Name;
                if (personas.Count(x => x.Name == nombre) > 1) return valor += valorDeRepetidos;
            }
            return valor;
        }

        private int validarVehiculosRepetidas(List<Persona> personas)
        {
            Vehicle vehicle;
            int valor = 0;
            foreach (Persona persona in personas)
            {
                vehicle = persona.Vehicle;
                if (personas.Count(x => x.Vehicle == vehicle) > 1) return valor += valorDeRepetidos;
            }
            return valor;
        }

        private int validarMouthActionsRepetidas(List<Persona> personas)
        {
            MouthAction mouthAction;
            int valor = 0;
            foreach (Persona persona in personas)
            {
                mouthAction = persona.MouthAction;
                if (personas.Count(x => x.MouthAction == mouthAction) > 1) return valor += valorDeRepetidos;
            }
            return valor;
        }

        private int validarNacionalidadesRepetidas(List<Persona> personas)
        {
            Nationality nacionalidad;
            int valor = 0;
            foreach (Persona persona in personas)
            {
                nacionalidad = persona.Nationality;
                if (personas.Count(x => x.Nationality == nacionalidad) > 1) return valor += valorDeRepetidos;
            }
            return valor;
        }

        #endregion

        public double FitnessFunction(Chromosome cromosoma)
        {
            double valor = 500;

            List<Persona> personas = crearModelos(cromosoma);

            //Polimorfismo para las validaciones
            foreach (var condicion in condiciones)
            {
                foreach (Persona persona in personas)
                {
                    valor += constanteDeFitness * condicion.valueFromPersona(persona);
                }

            }

            //me fijo si tiene partes invalidas => decremento el valor
            valor += constanteDeFitness * validarInvalidos(personas);

            //me fijo si hay posiciones repetidas => decremento el valor
            valor += constanteDeFitness * validarMouthActionsRepetidas(personas);

            //me fijo si hay colores repetidos => decremento el valor
            valor += constanteDeFitness * validarNacionalidadesRepetidas(personas);

            //me fijo si hay pertenencias repetidas => decremento el valor
            valor += constanteDeFitness * validarVehiculosRepetidas(personas);

            if (valor < 0) valor = 0;
            return valor;
        }

        private List<string> obtenerGenesAuxiliares(List<Gene> particion)
        {
            Chromosome cromosoma = new Chromosome();
            List<string> caracteristicas = new List<string>();
            var genes = particionar(particion, 3);
            int i = 0;
            foreach (var gen in genes)
            {
                cromosoma.Genes.Clear();
                cromosoma.Genes.AddRange(gen.ToList<Gene>());
                string cadenaBits = cromosoma.ToBinaryString();
                caracteristicas.Insert(i, cadenaBits);
                i++;
            }
            return caracteristicas;
        }

        private List<Persona> crearModelos(Chromosome cromosoma)
        {
            var particiones = particionar(cromosoma.Genes, 9);
            List<Persona> personas = new List<Persona>();
            int indice = 0;

            foreach (var particion in particiones)
            {
                //TODO Verificar el método obtenerGenesAuxiliares para obtener los genes principales y auxiliares
                List<string> genesAuxiliares = obtenerGenesAuxiliares(particion.ToList<Gene>());
                PersonaBuilder builder = PersonaBuilder.Instance;
                builder.configurar(indice, genesAuxiliares[0], genesAuxiliares[1], genesAuxiliares[2], "111");
                Persona modelo = builder.build();
                personas.Add(modelo);
                indice++;
            }
            return personas;
        }


        //metodo para particionar el cromosoma en genes principales y genes auxiliares
        public static IEnumerable<IEnumerable<T>> particionar<T>(IEnumerable<T> items,
                                                       int partitionSize)
        {
            if (partitionSize <= 0)
                throw new ArgumentOutOfRangeException("partitionSize");

            int innerListCounter = 0;
            int numberOfPackets = 0;
            foreach (var item in items)
            {
                innerListCounter++;
                if (innerListCounter == partitionSize)
                {
                    yield return items.Skip(numberOfPackets * partitionSize).Take(partitionSize);
                    innerListCounter = 0;
                    numberOfPackets++;
                }
            }

            if (innerListCounter > 0)
                yield return items.Skip(numberOfPackets * partitionSize);
        }
    }
}