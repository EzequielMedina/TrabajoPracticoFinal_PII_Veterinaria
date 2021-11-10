using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaLoginBack.Dominio
{
    public class Veterinario
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Matricula { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public int Domicilio { get; set; }
        public int Localidad { get; set; }
        public int TipoDni { get; set; }
        public string NroDni { get; set; }

        public override string ToString()
        {
            return Nombre + Apellido;
        }
    }
}
