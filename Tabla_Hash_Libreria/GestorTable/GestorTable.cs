using System.Collections.Generic;
using Tabla_Hash_Libreria.HashTable;

namespace Tabla_Hash_Libreria.GestorTable
{
    public abstract class GestorTable
    {
        protected Table hashTable; 

        public abstract bool  registarPersona(Persona persona);

        public abstract Persona buscarPorCedula(int cedula);

        public abstract List<Persona> buscarPorApellido(string apellido);
    }
}
