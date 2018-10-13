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

        public bool registarPersona(string nombre, string apellido, string cedula)
        {
            hashTable.insert(0, new Persona(cedula, nombre, apellido));

            return true;
        }

        public Persona buscarPorCedula(string cedula)
        {
            return hashTable.retrieve(0);
        }

        public Persona buscarPorApellido(string apellido)
        {
            return hashTable.retrieve(0);
        }
    }
}
