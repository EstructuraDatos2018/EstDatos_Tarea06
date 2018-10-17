using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_Hash_Libreria.HashTable
{
    class ClosedTable
    {
        private const int maxSize = 5;//tamaño de la tabla
        private HashNode[] table;

        public ClosedTable()
        {
            table = new HashNode[maxSize];

            for (int i = 0; i < maxSize; i++)
            {
                table[i] = null;
            }
        }

        public void insert(Persona persona)
        {
            if (!checkOpenSpace())//if no open spaces available
            {
                Console.WriteLine("table is at full capacity!");
                return;
            }
            int hash = (persona.cedula % maxSize);
            while (table[hash] != null && table[hash].getkey() != persona.cedula)
            {
                hash = (hash + 1) % maxSize;
            }
            table[hash] = new HashNode(persona);
        }

        public bool checkOpenSpace()
        {
            bool isOpen = false;
            for (int i = 0; i < maxSize; i++)
            {
                if (table[i] == null)
                {
                    isOpen = true;
                }
            }
            return isOpen;
        }

        public Persona retrieve(int key)
        {
            int hash = key % maxSize;
            while (table[hash] != null && table[hash].getkey() != key)
            {
                hash = (hash + 1) % maxSize;
            }
            if (table[hash] == null)
            {
                return null;
            }
            else
            {
                return table[hash].getdata();
            }
        }

        public List<Persona> retrieveByLastName(string lastName)
        {
            return null;
        }

        public void print()
        {
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] == null && i <= maxSize)//Si el espacio actual es nulo
                {
                    continue;//no lo imprime
                }
                else
                {
                    Console.WriteLine("{0}", table[i].getdata());
                }
            }
        }
    }
}
