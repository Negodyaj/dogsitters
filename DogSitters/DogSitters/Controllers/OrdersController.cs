using Microsoft.AspNetCore.Mvc;
using DogSitters.API.Models;
using AutoMapper;

namespace DogSitters.API.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMapper _mapper;

        public OrdersController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<OrderOutputModel>> GetAllOrders()
        {
            var storage = Business.Storage.GetInstance();
            var orderModelList = storage.Orders;
            var orderOutputModelList = _mapper.Map<List<OrderOutputModel>>(orderModelList);

            return Ok(orderOutputModelList);
        }

        [HttpGet("{orderId}")]
        public ActionResult<OrderOutputModel> GetOrderById(int orderId)
        {
            var storage = Business.Storage.GetInstance();
            var orderModel = storage.Orders[orderId];
            var orderOutputModel = _mapper.Map<OrderOutputModel>(orderModel);

            return Ok(orderOutputModel);
        }

        [HttpPost]
        public ActionResult AddOrder([FromBody] OrderInsertInputModel model)
        {
            var storage = Business.Storage.GetInstance();
            var orderModel = _mapper.Map<Business.Models.OrderModel>(model);
            storage.Orders.Add(orderModel);

            return Ok(orderModel);
        }

        [HttpPut("{orderId}")]
        public ActionResult UpdateOrder(int orderId, [FromBody] OrderUpdateInputModel model)
        {
            var storage = Business.Storage.GetInstance();
            var orderModel = _mapper.Map<Business.Models.OrderModel>(model);
            storage.Orders[orderId] = orderModel;

            return Ok(orderModel);
        }

        [HttpDelete("{orderId}")]
        public ActionResult DeleteOrder(int orderId)
        {
            var storage = Business.Storage.GetInstance();
            storage.Orders.RemoveAt(orderId);

            return NoContent();
        }

        [HttpPatch("{orderId}/sitter")]
        public ActionResult UpdateSitter(int orderId, [FromBody] int sitterId)
        {
            var storage = Business.Storage.GetInstance();
            var orderModel = storage.Orders[orderId];
            var sitterModel = storage.Sitters[sitterId];
            orderModel.Sitter = sitterModel;

            return Ok(orderModel);
        }
    }
}
