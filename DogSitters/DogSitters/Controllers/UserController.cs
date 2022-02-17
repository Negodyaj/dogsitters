using Microsoft.AspNetCore.Mvc;
using DogSitters.API.Models;

namespace DogSitters.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        ActionResult<UserOutputModel> GetAllUsers()
        {
            return Ok();
        }

        [HttpGet("{userId}")]
        ActionResult<UserOutputModel> GetUserById(int userId)
        {
            return Ok();
        }

        [HttpPost]
        ActionResult AddUser([FromBody] UserInsertInputModel model)
        {
            return Ok();
        }

        [HttpPut("{userId}")]
        ActionResult UpdateUser(int userId, [FromBody] UserUpdateInputModel model)
        {
            return Ok();
        }

        [HttpDelete("{userId}")]
        ActionResult DeleteUser(int userId)
        {
            return Ok();
        }

        [HttpPut("{userId}")]
        ActionResult UpdateAddress(int userId, string address, [FromBody] UserUpdateInputModel model)
        {
            return Ok();
        }

        [HttpPut("{userId}/dogs/{dogId}")]
        ActionResult AddDog(int userId, int dogId, [FromBody] UserUpdateInputModel model)
        {
            return Ok();
        }

        [HttpGet("{userId}/dogs")]
        ActionResult<UserOutputModel> GetAllDogsByUser(int userId)
        {
            return Ok();
        }

        [HttpGet("{userId}/dogs/{dogId}")]
        ActionResult<UserOutputModel> GetDog(int userId, int dogId)
        {
            return Ok();
        }

        [HttpPut("{userId}/dogs/{dogId}")]
        ActionResult UpdateDog(int userId, int dogId, [FromBody] UserUpdateInputModel model)
        {
            return Ok();
        }

        [HttpDelete("{userId}/dogs/{dogId}")]
        ActionResult DeleteDog(int userId, int dogId)
        {
            return Ok();
        }
    }
}
