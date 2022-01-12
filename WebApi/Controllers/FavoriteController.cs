using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Inputs;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteController : Controller
    {
        FavoriteService service;
        Favorite favorite;

        public FavoriteController()
        {
            service = new FavoriteService();
            favorite = new Favorite();
        }

        [HttpGet]
        public IActionResult Index() => Ok(service.GetAllFavorites());

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id) => Ok(service.GetFavorite(id));

        [HttpPost]
        public IActionResult Create(FavoriteInputModel favoriteInputModel)
        {
            favorite.FavoritesId = 0;
            favorite.UsrId = favoriteInputModel.UsrId;
            favorite.MvId = favoriteInputModel.MvId;
            favorite.SeId = favoriteInputModel.SeId;

            service.AddFavorite(favorite);

            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            service.DeleteFavorite(id);

            return Ok();
        }
    }
}
