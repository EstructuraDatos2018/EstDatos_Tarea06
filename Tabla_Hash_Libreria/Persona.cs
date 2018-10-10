using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_Hash_Libreria
{
    public class Persona
    {
        public string cedula { get; set; }
        public string nombre { get; set; }

        public Persona(string cedula,string nombre)
        {
            this.cedula = cedula;
            this.nombre = nombre;
        }
    }
}
