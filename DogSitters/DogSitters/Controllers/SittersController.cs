using Microsoft.AspNetCore.Mvc;
using DogSitters.API.Models;

namespace DogSitters.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SittersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<SitterOutputModel> GetAllSitters()
        {
            return Ok(new SitterOutputModel());
        }

        [HttpGet("{sitterId}")]
        public ActionResult<SitterOutputModel> GetSitterById(int sitterId)
        {
            return Ok(new SitterOutputModel { Id = sitterId });
        }

        [HttpPost]
        public ActionResult AddSitter([FromBody] SitterInsertInputModel model)
        {
            return Ok(model);
        }

        [HttpPut("{sitterId}")]
        public ActionResult UpdateSitter(int sitterId, [FromBody] SitterUpdateInputModel model)
        {
            return Ok(model);
        }

        [HttpDelete("{sitterId}")]
        public ActionResult DeleteSitter(int sitterId)
        {
            return NoContent();
        }

        [HttpPut("{sitterId}/approve")]
        public ActionResult ApproveSitter(int sitterId, [FromBody] SitterUpdateInputModel model)
        {
            return Ok(model);
        }

        [HttpPut("{sitterId}/reject")]
        public ActionResult RejectSitter(int sitterId, [FromBody] SitterUpdateInputModel model)
        {
            return Ok(model);
        }

        [HttpPut("{sitterId}/work-time")]
        public ActionResult UpdateWorkTime(int sitterId, [FromBody] SitterUpdateInputModel model)
        {
            return Ok(model);
        }

        [HttpPut("{sitterId}/metro-stations")]
        public ActionResult UpdateMetroStations(int sitterId, [FromBody] SitterUpdateInputModel model)
        {
            return Ok(model);
        }

        [HttpGet("{sitterId}/reviews/{reviewId}")]
        public ActionResult<SitterOutputModel> GetReview(int sitterId, int reviewId, [FromBody] ReviewOutputModel model)
        {
            return Ok(model);
        }

        [HttpPost("{sitterId}/reviews")]
        public ActionResult AddReview(int sitterId, [FromBody] ReviewInsertInputModel model)
        {
            return Ok(model);
        }

        [HttpPut("{sitterId}/reviews/{reviewId}")]
        public ActionResult UpdateReview(int sitterId, int reviewId, [FromBody] ReviewUpdateInputModel model)
        {
            return Ok();
        }

        [HttpDelete("{sitterId}/reviews/{reviewId}")]
        public ActionResult DeleteReview(int sitterId, int reviewId)
        {
            return NoContent();
        }

        [HttpGet("{sitterId}/reviews/{reviewId}/rating")]
        public ActionResult<SitterOutputModel> GetRating(int sitterId, int reviewId, [FromBody] ReviewOutputModel model)
        {
            return Ok(model);
        }

        [HttpPut("{sitterId}/reviews/{reviewId}/rating")]
        public ActionResult UpdateRating(int sitterId, int reviewId, [FromBody] ReviewUpdateInputModel model)
        {
            return Ok(model);
        }

        [HttpGet("{sitterId}/complaints/{complaintId}")]
        public ActionResult<SitterOutputModel> GetComplaint(int sitterId, int complaintId, [FromBody] ComplaintOutputModel model)
        {
            return Ok(model);
        }

        [HttpPost("{sitterId}/complaints")]
        public ActionResult AddComplaint(int sitterId, [FromBody] ComplaintInsertInputModel model)
        {
            return Ok(model);
        }

        [HttpPut("{sitterId}/complaints/{complaintId}")]
        public ActionResult UpdateComplaint(int sitterId, int complaintId, [FromBody] ComplaintUpdateInputModel model)
        {
            return Ok(model);
        }

        [HttpDelete("{sitterId}/complaints/{complaintId}")]
        public ActionResult DeleteComplaint(int sitterId, int complaintId)
        {
            return NoContent();
        }

        [HttpGet("{sitterId}/orders")]
        public ActionResult<OrderOutputModel> GetOrdersBySitter(int sitterId, [FromBody] OrderOutputModel model)
        {
            return Ok(model);
        }
    }
}
