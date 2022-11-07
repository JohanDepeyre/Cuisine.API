using Cuisine.Core.Infrastructures.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Cuisine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        //[HttpGet]
        //public IEnumerable<Photo> TestAmoi()
        //{
        //    return Enumerable.Range(1, 10).Select(item => new Photo() { Id = item });
        //}
        public readonly DatabaseContext _databaseContext;

        public PhotoController(DatabaseContext context)
        {
            this._databaseContext = context;
        }

        [HttpGet]
        public ActionResult<Photo> TestAmoi()
        {
            var model = this._databaseContext.Photos.Include(x=>x.Recette).ToList();

            return this.Ok(model);
        }
    }
}
