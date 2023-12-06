﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaTrabajoSMA.Shared.Models.FormularioEmpresa
{
    public class NombrePuesto

    {
        public int Id { get; set; }
        public string NombrePuest { get; set; }

        ICollection<NombrePuestoVacante> NombrePuestoVacantes { get; set; }


    }
}
