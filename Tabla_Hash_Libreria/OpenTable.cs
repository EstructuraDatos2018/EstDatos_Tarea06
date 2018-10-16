﻿using System;
using System.Collections.Generic;

namespace Tabla_Hash_Libreria
{
    public class OpenTable
    {
        private HashNode[] table;
        private const int size = 4;

        public OpenTable()
        {
            table = new HashNode[size];

            for (int i = 0; i < size; i++)
            {
                table[i] = null;
            }
        }

        public void insert(Persona persona)
        {
          HashNode nObj = new HashNode(persona);
            int hash = persona.cedula % size;
            while (table[hash] != null && table[hash].getkey() % size != persona.cedula % size)
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

            HashNode current = null;
            current = table[hash];
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

        public List<Persona> retrieveByLastName(string lastName)
        {
            return null;
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
