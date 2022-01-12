using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Inputs;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        UserService service;
        User user;

        public UserController()
        {
            service = new UserService();
            user = new User();
        }

        [HttpGet]
        public IActionResult Index() => Ok(service.GetAllUsers());

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id) => Ok(service.GetUser(id));

        [HttpPost]
        public IActionResult Create(UserInputModel userInputModel)
        {
            user.UsrId = 0;
            user.UsrName = userInputModel.UsrName;
            user.UsrEmail = userInputModel.UsrEmail;
            user.UsrPassword = userInputModel.UsrPassword;

            service.AddUpdateUser(user);

            return Ok();
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(UserInputModel userInputModel, int id)
        {
            user.UsrId = id;
            user.UsrName = userInputModel.UsrName;
            user.UsrEmail = userInputModel.UsrEmail;
            user.UsrPassword = userInputModel.UsrPassword;

            service.AddUpdateUser(user);

            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            service.DeleteUser(id);

            return Ok();
        }
    }
}
