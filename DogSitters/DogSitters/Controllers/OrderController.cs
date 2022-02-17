using Microsoft.AspNetCore.Mvc;
using DogSitters.API.Models;

namespace DogSitters.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        ActionResult<OrderOutputModel> GetAllOrders()
        {
            return Ok();
        }

        [HttpGet("{orderId}")]
        ActionResult<OrderOutputModel> GetOrderById(int orderId)
        {
            return Ok();
        }

        [HttpPost]
        ActionResult AddOrder([FromBody] OrderInsertInputModel model)
        {
            return Ok();
        }

        [HttpPut("{orderId}")]
        ActionResult UpdateOrder(int orderId, [FromBody] OrderUpdateInputModel model)
        {
            return Ok();
        }

        [HttpDelete("{orderId}")]
        ActionResult DeleteOrder(int orderId)
        {
            return Ok();
        }

        [HttpPut("{orderId}")]
        ActionResult SetSitter(int orderId, int sitterId, [FromBody] OrderUpdateInputModel model)
        {
            return Ok();
        }

        [HttpPut("{orderId}")]
        ActionResult SetDog(int orderId, int dogId, [FromBody] OrderUpdateInputModel model)
        {
            return Ok();
        }

        [HttpPut("{orderId}")]
        ActionResult SetUser(int orderId, int userId, [FromBody] OrderUpdateInputModel model)
        {
            return Ok();
        }
    }
}
