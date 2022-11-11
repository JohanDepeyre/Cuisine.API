using Cuisine.Core.Domain.Entity;
using Cuisine.Core.Domain.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cuisine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EtapeController : ControllerBase
    {

        public readonly IEtapeRepository _etapeRepository;
        public EtapeController(IEtapeRepository etapeRepository)
        {
            _etapeRepository = etapeRepository;
        }

       

        // GET api/<EtapeController>/5
        [HttpGet("{id}")]
        public ActionResult<Etape> GetAll([FromQuery] int idRecette)
        {
            var model = _etapeRepository.GetAll();

            return this.Ok(model);
        }

        // POST api/<EtapeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EtapeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EtapeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
