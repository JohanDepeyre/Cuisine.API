using Cuisine.Core.Infrastructures.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using Cuisine.Core.Domain.Repository;
using Cuisine.Core.Domain.Entity;

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
        public readonly IPhotoRepository _photoRepository;
        public readonly IWebHostEnvironment _webHostEnvironment;
        public PhotoController(IPhotoRepository photoRepository, IWebHostEnvironment webHostEnvironment)
        {
            this._photoRepository = photoRepository;
            this._webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        public ActionResult<Photo> GetAll([FromQuery] int idRecette)
        {
            var model = _photoRepository.GetAll();

            return this.Ok(model);
        }
        //[Route("photos")]
        //[HttpPost]
        //public async Task<IActionResult> AddPicture()
        //{
        //    using var stream = new StreamReader(this.Request.Body) ;
        //    var content = await stream.ReadToEndAsync();
        //    return this.Ok();
        //}
        [Route("photos")]
        [HttpPost]
        public async Task<IActionResult> AddPicture(IFormFile file)
        {
            string filePath = Path.Combine(this._webHostEnvironment.ContentRootPath, @"images\img_recettes");

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);

            }
            filePath = Path.Combine(filePath, file.FileName);
            using var stream = new FileStream(filePath, FileMode.OpenOrCreate);
            await file.CopyToAsync(stream);
           
            return this.Ok();
        }
        [HttpPost]
        public IActionResult AddOne(Photo photo)
        {
            IActionResult result = this.BadRequest();
            
            photo.ImagePath = "chemin";
            photo.IdRecette=1;
            photo.Title = "Titre photo";

            Photo addPhoto = this._photoRepository.AddOne(photo);

            _photoRepository.unitOfWork.SaveChanges();


            result= this.Ok(photo);
            return result;
        }
    }
}
