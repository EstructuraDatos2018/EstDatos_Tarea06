namespace Tabla_Hash_Libreria
{
    public class HashNode
    {
        public Persona data;
        HashNode next;
        public HashNode(Persona persona)
        {
            data = new Persona(
                persona.cedula,
                persona.nombre,
                persona.apellido);
            this.next = null;
        }

        public HashNode()
        {
            data = new Persona();
            
        }
        public int getkey()
        {
            return this.data.cedula;
        }
        public Persona getdata()
        {
            return data;
        }
        public void setNextNode(HashNode obj)
        {
            next = obj;
        }
        public HashNode getNextNode()
        {
            return this.next;
        }
    }
}


