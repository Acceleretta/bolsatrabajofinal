using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaTrabajoSMA.Shared.Models
{
    internal class Aptitudes
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public Empleado Empleado { get; set; }
    }
}
