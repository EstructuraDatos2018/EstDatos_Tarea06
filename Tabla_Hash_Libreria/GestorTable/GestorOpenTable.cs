using System.Collections.Generic;
using Tabla_Hash_Libreria;
using Tabla_Hash_Libreria.GestorTable;

namespace Tarea06
{
    public class GestorOpenTable : GestorTable
    {
        private OpenTable hashTable;

        public GestorOpenTable()
        {
            hashTable = new OpenTable();
        }

        public override bool registarPersona(Persona persona)
        {
            hashTable.insert(persona);
            hashTable.insertInStringTable(persona);

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
