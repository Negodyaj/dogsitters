using Microsoft.AspNetCore.Mvc;
using DogSitters.API.Models;

namespace DogSitters.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SitterController : ControllerBase
    {
        [HttpGet]
        ActionResult<SitterOutputModel> GetAllSitters()
        {
            return Ok();
        }

        [HttpGet("{sitterId}")]
        ActionResult<SitterOutputModel> GetSitterById(int sitterId)
        {
            return Ok();
        }

        [HttpPost]
        ActionResult AddSitter([FromBody] SitterInsertInputModel model)
        {
            return Ok();
        }

        [HttpPut("{sitterId}")]
        ActionResult UpdateSitter(int sitterId, [FromBody] SitterUpdateInputModel model)
        {
            return Ok();
        }

        [HttpDelete("{sitterId}")]
        ActionResult DeleteSitter(int sitterId)
        {
            return Ok();
        }

        [HttpPut("{sitterId}")]
        ActionResult ApproveSitter(int sitterId, [FromBody] SitterUpdateInputModel model)
        {
            return Ok();
        }

        [HttpPut("{sitterId}")]
        ActionResult RejectSitter(int sitterId, [FromBody] SitterUpdateInputModel model)
        {
            return Ok();
        }

        [HttpGet]
        ActionResult<SitterOutputModel> GetSittersByDateTime(DateTime dateTime)
        {
            return Ok();
        }

        [HttpPut("{sitterId}")]
        ActionResult UpdatePassport(int sitterId, string passport, [FromBody] SitterUpdateInputModel model)
        {
            return Ok();
        }

        [HttpPut("{sitterId}")]
        ActionResult UpdateWorkTime(int sitterId, string workTime, [FromBody] SitterUpdateInputModel model)
        {
            return Ok();
        }

        [HttpPut("{sitterId}")]
        ActionResult UpdateMetroStations(int sitterId, int[] metroStationIds, [FromBody] SitterUpdateInputModel model)
        {
            return Ok();
        }

        [HttpPut("{sitterId}")]
        ActionResult UpdatePrice(int sitterId, decimal price, [FromBody] SitterUpdateInputModel model)
        {
            return Ok();
        }

        [HttpGet("{sitterId}/reviews/{reviewId}")]
        ActionResult<SitterOutputModel> GetReview(int sitterId, int reviewId)
        {
            return Ok();
        }

        [HttpPost("{sitterId}/reviews")]
        ActionResult AddReview(int sitterId, [FromBody] SitterInsertInputModel model)
        {
            return Ok();
        }

        [HttpPut("{sitterId}/reviews/{reviewId}")]
        ActionResult UpdateReview(int sitterId, int reviewId, [FromBody] SitterUpdateInputModel model)
        {
            return Ok();
        }

        [HttpDelete("{sitterId}/reviews/{reviewId}")]
        ActionResult DeleteReview(int sitterId, int reviewId)
        {
            return Ok();
        }

        [HttpGet("{sitterId}/reviews/{reviewId}")]
        ActionResult<SitterOutputModel> GetRating(int sitterId, int reviewId)
        {
            return Ok();
        }

        [HttpPut("{sitterId}/reviews/{reviewId}")]
        ActionResult UpdateRating(int sitterId, int reviewId, [FromBody] SitterUpdateInputModel model)
        {
            return Ok();
        }

        [HttpGet("{sitterId}/complaints/{complaintId}")]
        ActionResult<SitterOutputModel> GetComplaint(int sitterId, int complaintId)
        {
            return Ok();
        }

        [HttpPost("{sitterId}/complaints")]
        ActionResult AddComplaint(int sitterId, [FromBody] SitterInsertInputModel model)
        {
            return Ok();
        }

        [HttpPut("{sitterId}/complaints/{complaintId}")]
        ActionResult UpdateComplaint(int sitterId, int complaintId, [FromBody] SitterUpdateInputModel model)
        {
            return Ok();
        }

        [HttpDelete("{sitterId}/complaints/{complaintId}")]
        ActionResult DeleteComplaint(int sitterId, int complaintId)
        {
            return Ok();
        }

        [HttpGet("{sitterId}")]
        ActionResult<SitterOutputModel> GetOrdersBySitter(int sitterId, int[] orderIds)
        {
            return Ok();
        }

        [HttpGet]
        ActionResult<SitterOutputModel> GetBigDogSitters()
        {
            return Ok();
        }
    }
}
