using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public IActionResult GetClSocialNeedsGoal()
        {
            try
            {
                List<ClSocialNeedsGoal> socialNeedsGoals = ClSocialNeedsGoalServiceService.GetClSocialNeedsGoal().ToList();

                if (socialNeedsGoals != null && socialNeedsGoals.Any())
                {
                    return Ok(socialNeedsGoals);
                }
                else
                {
                    return BadRequest("No social needs goal(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClSocialNeedsGoal/AddClSocialNeedsGoal")]
        public IActionResult AddClSocialNeedsGoal(ClSocialNeedsGoal ClSocialNeedsGoal)
        {
            try
            {
                ClSocialNeedsGoal socialNeedsGoal = ClSocialNeedsGoalServiceService.AddClSocialNeedsGoal(ClSocialNeedsGoal);

                if (socialNeedsGoal != null)
                {
                    return Ok(socialNeedsGoal);
                }
                else
                {
                    return BadRequest("Failed to add social needs goal.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClSocialNeedsGoal/UpdateClSocialNeedsGoal")]
        public IActionResult UpdateClSocialNeedsGoal(ClSocialNeedsGoal ClSocialNeedsGoal)
        {
            try
            {
                ClSocialNeedsGoal currentSocialNeedsGoal = ClSocialNeedsGoalServiceService.GetClSocialNeedsGoalById(ClSocialNeedsGoal.SocialNeedsGoalsId);

                if (currentSocialNeedsGoal != null)
                {
                    #region Social Needs Goal to update

                    currentSocialNeedsGoal.SocialNeedsGoalsId = ClSocialNeedsGoal.SocialNeedsGoalsId;
                    currentSocialNeedsGoal.ParticipantId = ClSocialNeedsGoal.ParticipantId;
                    currentSocialNeedsGoal.SocialNeedsDescription = ClSocialNeedsGoal.SocialNeedsDescription;

                    #endregion

                    ClSocialNeedsGoal socialNeedsGoal = ClSocialNeedsGoalServiceService.UpdateClSocialNeedsGoal(currentSocialNeedsGoal);

                    if (socialNeedsGoal != null)
                    {
                        return Ok(socialNeedsGoal);
                    }
                    else
                    {
                        return BadRequest("Failed to update social needs goal.");
                    }
                }
                else
                {
                    return BadRequest("Social needs goal not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClSocialNeedsGoal/DeleteClSocialNeedsGoal")]
        public IActionResult DeleteClSocialNeedsGoal(int id)
        {
            try
            {
                ClSocialNeedsGoal currentSocialNeedsGoal = ClSocialNeedsGoalServiceService.GetClSocialNeedsGoalById(id);

                if (currentSocialNeedsGoal != null)
                {
                    ClSocialNeedsGoal socialNeedsGoal = ClSocialNeedsGoalServiceService.DeleteClSocialNeedsGoal(id);

                    return Ok(socialNeedsGoal);
                }
                else
                {
                    return BadRequest("Social needs goal not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClSocialNeedsGoal/GetClSocialNeedsGoalById")]
        public IActionResult GetClSocialNeedsGoalById(int id)
        {
            try
            {
                ClSocialNeedsGoal socialNeedsGoal = ClSocialNeedsGoalServiceService.GetClSocialNeedsGoalById(id);

                if (socialNeedsGoal != null)
                {
                    return Ok(socialNeedsGoal);
                }
                else
                {
                    return BadRequest("Social needs goal not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClSocialNeedsGoal/GetClSocialNeedsGoalByParticipantId")]
        public IEnumerable<ClSocialNeedsGoal> GetClSocialNeedsGoalByParticipantId(int participantid)
        {
            return ClSocialNeedsGoalServiceService.GetClSocialNeedsGoalByParticipantId(participantid);
        }


    }
}
