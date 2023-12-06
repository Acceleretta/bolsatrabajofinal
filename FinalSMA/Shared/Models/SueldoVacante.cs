using BolsaTrabajoSMA.Shared.Models.FormularioEmpresa;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaTrabajoSMA.Shared.Models
{
    public class SueldoVacante
    {

        public int Id { get; set; }
        [Range(1, int.MaxValue)]
        public int VacanteId { get; set; }
        public Vacante? Vacante { get; set; }
        [Range(1, int.MaxValue)]
        public int SueldoId { get; set; }
        public Sueldo? Sueldos { get; set; }
    }
}
