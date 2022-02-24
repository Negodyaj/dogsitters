using Microsoft.AspNetCore.Mvc;
using DogSitters.API.Models;
using AutoMapper;

namespace DogSitters.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMapper _mapper;

        public UsersController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<UserOutputModel> GetAllUsers()
        {
            return Ok(new UserOutputModel());
        }

        [HttpGet("{userId}")]
        public ActionResult<UserOutputModel> GetUserById(int userId)
        {
            return Ok(new UserOutputModel { Id = userId });
        }

        [HttpPost]
        public ActionResult AddUser([FromBody] UserInsertInputModel model)
        {
            return Ok(model);
        }

        [HttpPut("{userId}")]
        public ActionResult UpdateUser(int userId, [FromBody] UserUpdateInputModel model)
        {
            return Ok(model);
        }

        [HttpDelete("{userId}")]
        public ActionResult DeleteUser(int userId)
        {
            return NoContent();
        }

        [HttpPut("{userId}/dogs")]
        public ActionResult AddDog(int userId, [FromBody] DogInsertInputModel model)
        {
            return Ok(model);
        }

        [HttpGet("{userId}/dogs")]
        public ActionResult<DogOutputModel> GetAllDogsByUserId(int userId)
        {
            return Ok(new DogOutputModel());
        }

        [HttpGet("{userId}/dogs/{dogId}")]
        public ActionResult<DogOutputModel> GetDogByUserId(int userId, int dogId)
        {
            return Ok(new DogOutputModel { Id = dogId });
        }

        [HttpPut("{userId}/dogs/{dogId}")]
        public ActionResult UpdateDog(int userId, int dogId, [FromBody] DogUpdateInputModel model)
        {
            return Ok(model);
        }

        [HttpDelete("{userId}/dogs/{dogId}")]
        public ActionResult DeleteDog(int userId, int dogId)
        {
            return NoContent();
        }

        [HttpGet("sitters/date-time")]
        public ActionResult<SitterOutputModel> GetSittersByDateTime([FromBody] SitterOutputModel model)
        {
            return Ok(model);
        }

        [HttpGet("sitters/metro-stations")]
        public ActionResult<SitterOutputModel> GetSittersByMetroStations([FromBody] SitterOutputModel model)
        {
            return Ok(model);
        }

        [HttpGet("sitters/fearless")]
        public ActionResult<SitterOutputModel> GetFearlessSitters([FromBody] SitterOutputModel model)
        {
            return Ok(model);
        }
    }
}
