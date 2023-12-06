using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaTrabajoSMA.Shared.Models
{
    public class Formacion
    {
        public int Id { get; set; }
        public DateTime? Anio { get; set; }
        public string? Nombre { get; set; }
        public string? Escuela { get; set; }
        public string? Municipio { get; set; }
        public string? Estado { get; set; }
        public string? Descripcion { get; set; }

        public Empleado Empleado { get; set; }


    }
}
