using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaClientesBack.Dominio
{
    public class Cliente
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int Codigo { get; set; }

        public int NroDocumento { get; set; }

        public int TipoDoc { get; set; }

        public string Calle { get; set; }

        public int NroCalle { get; set; }

        public int Localidad { get; set; }

        public Mascota Mascota { get; set; }
        public string NombreLocalidad { get; internal set; }
        public string TipoDniEnLetras { get; internal set; }

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
