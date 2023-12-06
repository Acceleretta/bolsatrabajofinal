using BolsaTrabajoSMA.Shared.Models.FormularioEmpresa;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaTrabajoSMA.Shared.Models
{
    public class NombrePuestoVacante
    {
        public int Id { get; set; }
        [Range(1, int.MaxValue)]
        public int VacanteId { get; set; }
        public Vacante? Vacante { get; set; }
        [Range(1, int.MaxValue)]
        public int NombrePuestId { get; set; }
        public NombrePuesto? NombrePuest{ get; set; }


    }
}
