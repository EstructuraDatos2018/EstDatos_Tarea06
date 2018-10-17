using System;
using System.Collections.Generic;
using Tabla_Hash_Libreria.HashTable;

namespace Tabla_Hash_Libreria
{
    public class OpenTable : Table
    {

        public OpenTable()
        {
            table = new HashNode[size];
            tableString = new HashNode[size];

            for (int i = 0; i < size; i++)
            {
                table[i] = null;
                tableString[i] = null;
            }
        }

        public override void insert(Persona persona)
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

        public void insertInStringTable(Persona persona)
        {
            persona.apellido = persona.apellido.ToLower();
            HashNode nObj = new HashNode(persona);
            int lastNameLength = persona.apellido.Length;
            int hashString =  lastNameLength % size;
            
            while (tableString[hashString] != null && tableString[hashString].GetLastNameKey() % size != lastNameLength % size)
            {
                hashString = (hashString + 1) % size;
            }
            if (tableString[hashString] != null && hashString == tableString[hashString].GetLastNameKey() % size)
            {
                nObj.setNextNode(tableString[hashString].getNextNode());
                tableString[hashString].setNextNode(nObj);
                return;
            }
            else
            {
                tableString[hashString] = nObj;
                return;
            }
           
        }

        public override Persona retrieve(int key)
        {
          
            int hash = key % size;
            while (table[hash] != null && table[hash].getkey() % size != key % size)
            {
                hash = (hash + 1) % size;
            }

            HashNode current  = table[hash];
            if (current == null)
            {
                current = new HashNode();
            }

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

        public override List<Persona> retrieveByLastName(string lastName)
        {
            bool esNull = false;
            List<Persona> lista = new List<Persona>();
            int lastNameLength = lastName.Length;
            int hashString = lastNameLength % size;
            HashNode current = tableString[hashString];

            if (current!= null)
            {
                while (current!=null && current.getdata().apellido.Equals(lastName.ToLower()) && esNull == false)
                {
                    lista.Add(current.getdata());
                    if (current.getNextNode() == null)
                    {
                        esNull = true;
                    }
                    current = current.getNextNode();
                   
                }
            }
            else
            {
                lista = null;
            }



            return lista;
        }

        public override void print()
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
