using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_Hash_Libreria
{
    class OpenTable
    {
        HashNode[] table;
        const int size = 10;

        public OpenTable()
        {
            table = new HashNode[size];
            for (int i = 0; i < size; i++)
            {
                table[i] = null;
            }
        }
        public void insert(int key, Persona data)
        {
            HashNode nObj = new HashNode(key, data);
            int hash = key % size;
            while (table[hash] != null && table[hash].getkey() % size != key % size)
            {
                hash = (hash + 1) % size;
            }
            if (table[hash] != null && hash == table[hash].getkey() % size)
            {
                nObj.setNextNode(table[hash].getNextNode());
                table[hash].setNextNode(nObj);
                return;
            }
            else
            {
                table[hash] = nObj;
                return;
            }
        }
        public Persona retrieve(int key)
        {
            int hash = key % size;
            while (table[hash] != null && table[hash].getkey() % size != key % size)
            {
                hash = (hash + 1) % size;
            }
            HashNode current = table[hash];
            while (current.getkey() != key && current.getNextNode() != null)
            {
                current = current.getNextNode();
            }
            if (current.getkey() == key)
            {
                return current.getdata();
            }
            else
            {
                return null;
            }
        }
        public void print()
        {
            HashNode current = null;
            for (int i = 0; i < size; i++)
            {
                current = table[i];
                while (current != null)
                {
                    Console.Write(current.getdata() + " ");
                    current = current.getNextNode();
                }
                Console.WriteLine();
            }
        }



    }
}
