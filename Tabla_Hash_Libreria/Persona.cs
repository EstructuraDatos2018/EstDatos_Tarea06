namespace Tabla_Hash_Libreria
{
    public class Persona
    {
        private string cedula { get; set; }
        private string nombre { get; set; }
        private string apellido { get; set; }

        public Persona(string cedula, string nombre, string apellido)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}
