using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Entidades;

namespace PruebaTecnica.Controllers
{
    [ApiController]
    [Route("api/ts/operacion/v1")]
    public class OperacionController: ControllerBase
    {
        private readonly AplicationDbContext context;

        public OperacionController(AplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<Respuesta> RegistrarOperacionProgramada([FromBody] Operacion operacion)
        {          
            try
            {
                context.Add(operacion);
                await context.SaveChangesAsync();
                return new Respuesta("200", "Registro ingresado");
            }
            catch (Exception ex)
            {
                return new Respuesta("500", "Ocurrio un erro: " + ex.StackTrace.ToString());
            }

        }
    }
}
