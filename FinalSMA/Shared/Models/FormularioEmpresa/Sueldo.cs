using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaTrabajoSMA.Shared.Models.FormularioEmpresa
{
    public class Sueldo
    {
        public int Id { get; set; }
        public string Sueldos { get; set; }

        ICollection<SueldoVacante> SueldosVacantes { get; set; }
    }
}
