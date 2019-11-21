using Microsoft.AspNetCore.Mvc;

namespace EndpointRoutingStrange.Controllers
{
    public class MainController : ControllerBase
    {
        [HttpGet("personalpage/{userID:long}/{**filterString}")]
        public ActionResult Index()
        {
            return new JsonResult(new {result = "personalpage"});
        }

        [HttpGet("{subjectType:dummy}/{subjectId:long}/reviews/{**filterString}")]
        public ActionResult Reviews()
        {
            return new JsonResult(new { result = "reviews" });
        }
    }
}
