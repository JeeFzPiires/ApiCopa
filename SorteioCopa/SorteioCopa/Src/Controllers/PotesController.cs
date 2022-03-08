using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SorteioCopa.Data;
using System.Linq;

namespace SorteioCopa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PotesController : ControllerBase
    {

        [HttpGet]

        public ActionResult Padrao()
        {
            return Ok("ok");
        }

        [HttpGet("ObterPotes")]

        public ActionResult ObterPotes()
        {
            var data = new CopaContex();
            var result = data.Potes.ToList();

            if (result == null)
            {
                return BadRequest("Não existe potes na base de dados.");
            }
            return Ok(result);
        }

        /*public ActionResult SorteioPotes()
        {
            var data = new CopaContex();
            var result = data.Potes.ToList();
            var sede = 


        }*/

    }
}
