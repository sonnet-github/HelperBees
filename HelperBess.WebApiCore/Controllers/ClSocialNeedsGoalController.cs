using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]
    public class ClSocialNeedsGoalController : ControllerBase
    {
        private readonly IClSocialNeedsGoalService ClSocialNeedsGoalServiceService;
        public ClSocialNeedsGoalController(IClSocialNeedsGoalService iClSocialNeedsGoalService)
        {
            ClSocialNeedsGoalServiceService = iClSocialNeedsGoalService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClSocialNeedsGoal/GetClSocialNeedsGoal")]
        public IEnumerable<ClSocialNeedsGoal> GetClSocialNeedsGoal()
        {
            return ClSocialNeedsGoalServiceService.GetClSocialNeedsGoal();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClSocialNeedsGoal/AddClSocialNeedsGoal")]
        public ClSocialNeedsGoal AddClSocialNeedsGoal(ClSocialNeedsGoal ClSocialNeedsGoal)
        {
            return ClSocialNeedsGoalServiceService.AddClSocialNeedsGoal(ClSocialNeedsGoal);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClSocialNeedsGoal/UpdateClSocialNeedsGoal")]
        public ClSocialNeedsGoal UpdateClSocialNeedsGoal(ClSocialNeedsGoal ClSocialNeedsGoal)
        {
            return ClSocialNeedsGoalServiceService.UpdateClSocialNeedsGoal(ClSocialNeedsGoal);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClSocialNeedsGoal/DeleteClSocialNeedsGoal")]
        public ClSocialNeedsGoal DeleteClSocialNeedsGoal(int id)
        {
            return ClSocialNeedsGoalServiceService.DeleteClSocialNeedsGoal(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClSocialNeedsGoal/GetClSocialNeedsGoalById")]
        public ClSocialNeedsGoal GetClSocialNeedsGoalById(int id)
        {
            return ClSocialNeedsGoalServiceService.GetClSocialNeedsGoalById(id);
        }
    }
}
