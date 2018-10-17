using System.Collections.Generic;
using Tabla_Hash_Libreria;
using Tabla_Hash_Libreria.HashTable;

namespace Tarea06
{
    public class GestorClosedTable
    {
        private ClosedTable hashTable;

        public GestorClosedTable()
        {
            hashTable = new ClosedTable();
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

        public bool eliminar(int cedula)
        {
            return hashTable.remove(cedula);
        }
    }
}
