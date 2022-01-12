using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Inputs;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserWatchController : Controller
    {
        UserWatchService service;
        UserWatch userWatch;

        public UserWatchController()
        {
            service = new UserWatchService();
            userWatch = new UserWatch();
        }

        [HttpPost]
        public IActionResult Create(UserWatchInputModel userWatchInputModel)
        {
            userWatch.UsrId = userWatchInputModel.UsrId;
            userWatch.MvId = userWatchInputModel.MvId;
            userWatch.SeId = userWatchInputModel.SeId;

            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            service.DeleteUserWatch(id);
            return Ok();
        }
    }
}
