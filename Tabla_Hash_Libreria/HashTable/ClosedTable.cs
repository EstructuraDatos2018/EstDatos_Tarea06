using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_Hash_Libreria.HashTable
{
    class ClosedTable : Table
    {
        private const int size = 5;
        private HashNode[] table;

        public ClosedTable()
        {
            table = new HashNode[size];

            for (int i = 0; i < size; i++)
            {
                table[i] = null;
            }
        }

        public override void insert(Persona persona)
        {
            if (!checkOpenSpace())//si no hay espacios abiertos
            {
                Console.WriteLine("");
                Console.WriteLine("No se pueden ingresar mas datos!");
                Console.WriteLine("");
                return;
            }
            int hash = (persona.cedula % size);
            while (table[hash] != null && table[hash].getkey() != persona.cedula)
            {
                hash = (hash + 1) % size;
            }
            table[hash] = new HashNode(persona);
        }

        public bool remove(int key)
        {
            int hash = key % size;
            while (table[hash] != null && table[hash].getkey() != key)
            {
                hash = (hash + 1) % size;
            }
            if (table[hash] == null)
            {
                return false;
            }
            else
            {
                table[hash] = null;
                return true;
            }
        }

        public bool checkOpenSpace()
        {
            bool isOpen = false;
            for (int i = 0; i < size; i++)
            {
                if (table[i] == null)
                {
                    isOpen = true;
                }
            }
            return isOpen;
        }

        public override Persona retrieve(int key)
        {
            int hash = key % size;
            while (table[hash] != null && table[hash].getkey() != key)
            {
                hash = (hash + 1) % size;
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

        public override List<Persona> retrieveByLastName(string lastName)
        {
            List<Persona> lista = null;
            foreach (HashNode node in table)
            {
                if (node.getdata().apellido.Equals(lastName))
                {
                    lista.Add(node.getdata());
                }
            }
            return lista;
        }

        public override void print()
        {
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] == null && i <= size)//Si el espacio actual es nulo
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
