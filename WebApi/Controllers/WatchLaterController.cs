using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Inputs;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WatchLaterController : Controller
    {
        WatchLaterService service;
        WatchLater watchLater;

        public WatchLaterController()
        {
            service = new WatchLaterService();
            watchLater = new WatchLater();
        }

        [HttpPost]
        public IActionResult Create(WatchLaterInputModel watchLaterInputModel)
        {
            watchLater.UsrId = watchLaterInputModel.UsrId;
            watchLater.MvId = watchLaterInputModel.MvId;
            watchLater.SeId = watchLaterInputModel.SeId;

            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            service.DeleteWatchLater(id);
            return Ok();
        }
    }
}
