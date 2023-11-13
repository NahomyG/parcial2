using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2
{
    internal class Profesor : Persona
    {
        public string Titulo {  get; set; }
        public string CarreraAsignada { get; set; }
        public double Salario { get; set; }

        public string MostrarInformacion()
        {
            return $"Nombre: {NombreCompleto()}, Titulo: {Titulo}, Carrera Asignada: {CarreraAsignada}, Salario: {Salario}";
        }
    }
}
