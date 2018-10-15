using System.Collections.Generic;
using Tabla_Hash_Libreria;

namespace Tarea06
{
    public class Gestor
    {
        private OpenTable hashTable;

        public Gestor()
        {
            hashTable = new OpenTable();
        }

        public bool registarPersona(Persona persona)
        {
            hashTable.insert(persona);

            return true;
        }

        public Persona buscarPorCedula(int cedula)
        {
            return hashTable.retrieve(cedula);
        }

        public List<Persona> buscarPorApellido(string apellido)
        {
            return hashTable.retrieveByLastName(apellido);
        }
    }
}
