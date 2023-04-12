using ApiSemana9.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSemana9.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class SemanaController : ControllerBase 
    {
        private readonly SemanaContext semanaContext;

        public SemanaController(SemanaContext semanaContext)
        {
            this.semanaContext = semanaContext;
        }
        [HttpPost]
        public ActionResult<SemanaModel> Post([FromBody] SemanaModel semanaModel)
        {
            semanaModel.Id = semanaModel.Id;
                       
        if(semanaModel.Id > 0 )
        {
          return Ok();   

        }

        return BadRequest("Não é possível incluir no registro");

        }

        [HttpPut]
        [Route("{id}")]

        public ActionResult Put([FromBody] SemanaModel semanaModel, [FromRoute] int id)
        {
             if(semanaModel.Id == id)
             {
                return Ok();
             }

             return BadRequest("Id não encontrado");

        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            return BadRequest("Id não encontrado");
        }

        [HttpGet]
        public ActionResult Get ([FromRoute] int id)
        {
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult GetId ([FromRoute] int id)
        {
            return Ok();

        }

}  


