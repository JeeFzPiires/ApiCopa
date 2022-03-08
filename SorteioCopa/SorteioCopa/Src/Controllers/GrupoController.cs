using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SorteioCopa.Data;
using System.Linq;

namespace SorteioCopa.Src.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrupoController : ControllerBase
    {
        [HttpGet("ObterGrupo")]

        public ActionResult ObterGrupo()
        {
            var data = new CopaContex();
            var result = data.GrupoCopa.ToList();

            if (result == null)
            {
                return BadRequest("Não existe potes na base de dados.");
            }
            return Ok(result);
        }


    }
}
