using BolsaTrabajoSMA.Shared.Models.FormularioEmpresa;
using BolsaTrabajoSMA.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaTrabajoSMA.Shared.Models
{
    public class Padre

        
    {
        public int Id { get; set; }

        public NombrePuesto NombrePuesto  { get; set; }

        public Responsabilidades Responsabilidades { get; set; }

        public Habilidades Habilidades { get; set; }


        public Beneficios Beneficios { get; set; }
    }
}
