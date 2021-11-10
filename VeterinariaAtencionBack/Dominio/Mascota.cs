using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaAtencionBack.Dominio;

namespace VeterinariaMascotaBack.Dominio
{
    public class Mascota
    {
        public int IdMascota { get; set; }
        public string Nombre { get; set; }

        public int Especie  { get; set; }

        public DateTime FechaNac { get; set; }

        public DateTime? FechaDefun { get; set; }

        public int Sexo { get; set; }


        public bool Esterilizado { get; set; }

        public List<Atencion> Atenciones { get; set; }

        public int Clientes { get; set; }
        public object Raza { get; set; }
        public string SexoEnLetras { get; set; }
        public string EspecieEnLetras { get; set; }
        public string ClienteEnLetras { get; set; }
        public string RazaEnLetras { get; set; }
        public string EsterilizadoEnLetras { get; set; }

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
