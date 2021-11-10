using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpiVeterinaria.Dominio
{
    class Cliente
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }
  
        public int Codigo { get; set; }

        public int NroDocumento { get; set; }

        public int TipoDoc { get; set; }

        public Mascota Mascota { get; set; }

        public Cliente()
        {
            Mascota = new Mascota();
        }

        public override string ToString()
        {
            return Nombre + ' ' + Apellido + ' ' + NroDocumento.ToString();
        }
    }
}
