using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2
{
    internal class Estudiante : Persona
    {
        public int Ciclo { get; set; }
        public double Cum {  get; set; }
        public string Carrera { get; set; }

        public string MostrarInformacion()
        {
            return $"Nombre: {NombreCompleto()}, Ciclo: {Ciclo}, CUM: {Cum}, Carrera: {Carrera}" ;
        }
    }
}
