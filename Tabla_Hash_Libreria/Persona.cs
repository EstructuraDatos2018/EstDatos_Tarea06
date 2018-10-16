namespace Tabla_Hash_Libreria
{
    public class Persona
    {
        public int cedula { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        public Persona(int cedula, string nombre, string apellido)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona()
        {
            this.cedula = 0;
        }
    }
}
