using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SerieController : Controller
    {
        SerieService service;
        Serie serie;

        public SerieController()
        {
            service = new SerieService();
            serie = new Serie();
        }

        [HttpGet]
        public IActionResult Index() => Ok(service.GetAllSeries());

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id) => Ok(service.GetSerie(id));

        [HttpPost]
        public IActionResult Create(SerieInputModel serieInputModel)
        {
            serie.SeId = 0;
            serie.SeTitle = serieInputModel.SeTitle;
            serie.SeDate = serieInputModel.SeDate;
            serie.SeImg = serieInputModel.SeImg;
            serie.SeQtdSeasons = serieInputModel.SeQtdSeasons;
            serie.SeSynopsis = serieInputModel.SeSynopsis;
            serie.GrId = serieInputModel.GrId;

            service.AddUpdateSerie(serie);

            return Ok();
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(SerieInputModel serieInputModel, int id)
        {
            serie.SeId = id;
            serie.SeTitle = serieInputModel.SeTitle;
            serie.SeDate = serieInputModel.SeDate;
            serie.SeImg = serieInputModel.SeImg;
            serie.SeQtdSeasons = serieInputModel.SeQtdSeasons;
            serie.SeSynopsis = serieInputModel.SeSynopsis;
            serie.GrId = serieInputModel.GrId;

            service.AddUpdateSerie(serie);

            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            service.Delete(id);

            return Ok();
        }
    }
}
