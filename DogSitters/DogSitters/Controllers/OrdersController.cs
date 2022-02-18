using Microsoft.AspNetCore.Mvc;
using DogSitters.API.Models;

namespace DogSitters.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<OrderOutputModel> GetAllOrders()
        {
            return Ok(new OrderOutputModel());
        }

        [HttpGet("{orderId}")]
        public ActionResult<OrderOutputModel> GetOrderById(int orderId)
        {
            return Ok(new OrderOutputModel { Id = orderId });
        }

        [HttpPost]
        public ActionResult AddOrder([FromBody] OrderInsertInputModel model)
        {
            return Ok(model);
        }

        [HttpPut("{orderId}")]
        public ActionResult UpdateOrder(int orderId, [FromBody] OrderUpdateInputModel model)
        {
            return Ok(model);
        }

        [HttpDelete("{orderId}")]
        public ActionResult DeleteOrder(int orderId)
        {
            return NoContent();
        }

        [HttpPatch("{orderId}/sitter")]
        public ActionResult UpdateSitter(int orderId, int sitterId)
        {
            return Ok(this);
        }
    }
}
