using System.Collections.Generic;
using Tabla_Hash_Libreria;
using Tabla_Hash_Libreria.GestorTable;
using Tabla_Hash_Libreria.HashTable;

namespace Tarea06
{
    public class GestorClosedTable : GestorTable
    {

        public GestorClosedTable()
        {
            hashTable = new ClosedTable();
        }

        public override bool registarPersona(Persona persona)
        {
            hashTable.insert(persona);

            return true;
        }

        public override Persona buscarPorCedula(int cedula)
        {
            return hashTable.retrieve(cedula);
        }

        public override List<Persona> buscarPorApellido(string apellido)
        {
            return hashTable.retrieveByLastName(apellido);
        }

      
    }
}
