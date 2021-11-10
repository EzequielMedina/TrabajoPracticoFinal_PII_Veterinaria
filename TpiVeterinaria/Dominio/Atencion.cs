using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpiVeterinaria.Dominio
{
    class Atencion
    {
        public int NumeroAtencion { get; set; }
        public DateTime Fecha { get; set; }

        public string Descripcion { get; set; }

        public double Importe { get; set; }

        public DateTime FechaControl { get; set; }

        public DateTime FechaBaja { get; set; }

        public int IdMascota { get; set; }

        public string GetFechaBajaFormato()
        {
            string aux = FechaBaja.ToString("dd/MM/yyyy");
            return aux.Equals("01/01/0001") ? "" : aux;
        }

    }
}
