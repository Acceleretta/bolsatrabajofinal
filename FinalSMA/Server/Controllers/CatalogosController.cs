//using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BolsaTrabajoSMA.Server.Data;
using BolsaTrabajoSMA.Server.Data;
using BolsaTrabajoSMA.Shared.Models.FormularioEmpresa;
using BolsaTrabajoSMA.Shared.Models;

namespace BolsaSMA.Server.Controllers
{
    //Agregamos seguridad de autenticación a nuestro controlador
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogosController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public CatalogosController(ApplicationDbContext context)
        {
            this.context = context;
        }


        [HttpGet("TipoContratacion")]
        public async Task<List<TipoContratacion>> TipoContrataciones()
        {
            List<TipoContratacion> tipocontrataciones = new List<TipoContratacion>();
            tipocontrataciones = await context.tipoContrataciones.ToListAsync();

            return tipocontrataciones;
        }

        [HttpGet("Modalidad")]
        public async Task<List<Modalidades>> moda()
        {
            List<Modalidades> moda = new List<Modalidades>();
            moda = await context.moda.ToListAsync();

            return moda;
        }

        [HttpGet("NivelEscolaridad")]
        public async Task<List<NivelEscolaridad>> escolaridades()
        {
            List<NivelEscolaridad> escolaridades = new List<NivelEscolaridad>();
            escolaridades = await context.escolaridades.ToListAsync();

            return escolaridades;
        }

        [HttpPost("NombrePuesto")]
        public async Task<int> NuevoPuesto(NombrePuesto nuevoPuesto)
        {
            context.Add(nuevoPuesto);
            await context.SaveChangesAsync();
            return nuevoPuesto.Id;
        }
    
        [HttpPost("Responsabilidad")]
        public async Task<int> NuevaResponsabilidad(Responsabilidades nuevaResponsabilidad)
        {
            context.Add(nuevaResponsabilidad);
            await context.SaveChangesAsync();
            return nuevaResponsabilidad.Id;
        }

        [HttpPost("Habilidad")]
        public async Task<int> NuevaHabilidad(Habilidades nuevaHabilidad)
        {
            context.Add(nuevaHabilidad);
            await context.SaveChangesAsync();
            return nuevaHabilidad.Id;
        }

        [HttpPost("Sueldo")]
        public async Task<int> NuevoSueldo(Sueldo nuevoSueldo)
        {
            context.Add(nuevoSueldo);
            await context.SaveChangesAsync();
            return nuevoSueldo.Id;
        }

        [HttpPost("Beneicios")]
        public async Task<int> NuevoBeneficios(Beneficios nuevoBeneficios)
        {
            context.Add(nuevoBeneficios);
            await context.SaveChangesAsync();
            return nuevoBeneficios.Id;
        }


    }
}
