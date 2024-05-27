using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        [HttpGet]
        public IActionResult ListarPersona()
        {
            return Ok("aqui retorno la lista de personas");
        }

    }
}
