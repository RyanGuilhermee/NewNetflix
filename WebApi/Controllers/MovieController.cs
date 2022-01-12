using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        MovieService service;
        Movie movie;

        public MovieController()
        {
            service = new MovieService();
            movie = new Movie();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(service.GetAllMovies());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            MovieOutputModel movieOutputModel = new MovieOutputModel();

            Movie movieRes = service.GetMovie(id);

            movieOutputModel.MvId = movieRes.MvId;
            movieOutputModel.MvTitle = movieRes.MvTitle;
            movieOutputModel.MvDate = movieRes.MvDate;
            movieOutputModel.MvImg = movieRes.MvImg;
            movieOutputModel.MvDuration = movieRes.MvDuration;
            movieOutputModel.MvSynopsis = movieRes.MvSynopsis;
            movieOutputModel.GrId = movieRes.GrId;

            return Ok(movieOutputModel);
        }

        [HttpPost]
        public IActionResult Create(MovieInputModel movieInputModel)
        {
            movie.MvId = 0;
            movie.MvTitle = movieInputModel.MvTitle;
            movie.MvDate = movieInputModel.MvDate;
            movie.MvImg = movieInputModel.MvImg;
            movie.MvDuration = movieInputModel.MvDuration;
            movie.MvSynopsis = movieInputModel.MvSynopsis;
            movie.GrId = movieInputModel.GrId;

            service.AddUpdateMovie(movie);

            return Ok(); 
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(MovieInputModel movieInputModel, int id)
        {
            movie.MvId = id;
            movie.MvTitle = movieInputModel.MvTitle;
            movie.MvDate = movieInputModel.MvDate;
            movie.MvImg = movieInputModel.MvImg;
            movie.MvDuration = movieInputModel.MvDuration;
            movie.MvSynopsis = movieInputModel.MvSynopsis;
            movie.GrId = movieInputModel.GrId;

            service.AddUpdateMovie(movie);

            return Ok(200);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            service.Delete(id);

            return Ok();
        }
    }
}
