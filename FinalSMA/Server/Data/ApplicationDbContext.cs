using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BolsaTrabajoSMA.Shared.Models.FormularioEmpresa;
using BolsaTrabajoSMA.Shared.Models;
using System.Collections.Generic;
//using System.Reflection.Emit;

namespace BolsaTrabajoSMA.Server.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //internal object tipocontrataciones;
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<TipoContratacion> tipoContrataciones { get; set; }

        public DbSet<NombrePuesto> nombrePuestos { get; set; }
        public DbSet<NivelEscolaridad> escolaridades { get; set; }

        public DbSet<Habilidades> habilidades { get; set; }

        public DbSet<Responsabilidades> responsabilidades { get; set; }

        public DbSet<Modalidades> moda { get; set; }

        public DbSet<ListaPaises> listaPaises { get; set; }

        public DbSet<Empleado> empleados { get; set; }

        public DbSet<Formacion> formaciones { get; set; }

        public DbSet<HistorialLaboral> historialLaboral { get; set; }

        public DbSet<Vacante> vacantees { get; set;}

        public DbSet<Beneficios> beneficios { get; set; }

        public DbSet<ExperienciaRequerida> experienciaRequeridas { get; set; }

        public DbSet<BeneficiosVacante> beneficiosVacantes { get; set; }
        public DbSet<ExperienciaVacante> experienciaVacantes { get; set; }

        public DbSet<FuncionesVacante> funcionesVacantes { get; set;}

        public DbSet<HabilidadesVacante> habilidadesVacantes { get; set; }

        public DbSet<NombrePuestoVacante> nombrePuestoVacantes { get; set; }

        public DbSet<SueldoVacante> sueldoVacantes { get; set; }

        public DbSet<ResponsabilidadesVacante> responsabilidadesVacantes { get; set; }

        //public DbSet<ModalidadesVacante> modalidadesVacantes { get; set; }

        //public DbSet<Padre> padres { get; set; }


    }
}
