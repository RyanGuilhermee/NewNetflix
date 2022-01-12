using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Inputs;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenreController : Controller
    {
        GenreService service;
        Genre genre;

        public GenreController()
        {
            service = new GenreService();  
            genre = new Genre();
        }

        [HttpGet]
        public IActionResult Index() => Ok(service.GetAllGenres());

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id) => Ok(service.GetGenre(id));

        [HttpPost]
        public IActionResult Create(GenreInputModel genreInputModel)
        {
            genre.GrId = 0;
            genre.Genre1 = genreInputModel.Genre1;
         
            service.AddGenre(genre);

            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            service.DeleteGenre(id);

            return Ok();
        }
    }
}
