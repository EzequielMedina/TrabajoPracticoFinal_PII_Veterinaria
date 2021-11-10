using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpiVeterinaria.Dominio
{
    class Mascota
    {
        public int IdMascota { get; set; }
        public string Nombre { get; set; }

        public int Especie  { get; set; }

        public DateTime FechaNac { get; set; }

        public List<Atencion> Atenciones { get; set; }

        public Mascota()
        {
            Atenciones = new List<Atencion>();
        }

        public override string ToString()
        {
            return Nombre; 
        }

    }
}
