using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2
{
    internal class Persona
    {
        public int Edad {  get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechadeNacimiento { get; set; }

        public string NombreCompleto()
        {
            return $"{Nombres} {Apellidos}";
        }
       

    }
}
