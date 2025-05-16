using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<UsuarioModel>> BuscaTodosUsuario()
        {
            return Ok();
        }
        [HttpGet]
        public ActionResult<UsuarioModel> BuscarPorId(int id)
        {
            return Ok() ;
        }

    }
}
