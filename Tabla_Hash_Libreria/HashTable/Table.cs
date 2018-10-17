using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_Hash_Libreria.HashTable
{
    public abstract class Table
    {
        protected const int size = 5;//tamaño de la tabla
        protected HashNode[] table;
        protected HashNode[] tableString;

        public abstract void insert(Persona persona);

        public abstract Persona retrieve(int key);

        public abstract List<Persona> retrieveByLastName(string lastName);

        public abstract void print();
    }
}
