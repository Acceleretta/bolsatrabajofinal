using BolsaTrabajoSMA.Server.Data;
using BolsaTrabajoSMA.Shared.Models;
using BolsaTrabajoSMA.Shared.Models.FormularioEmpresa;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BolsaTrabajoSMA.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public EmpleadosController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpPost("empleados")]
        public async Task<int> NuevoEmpleado(Empleado nuevoempleado)
        {
            context.Add(nuevoempleado);
            await context.SaveChangesAsync();
            return nuevoempleado.Id;
        }


    }
}
