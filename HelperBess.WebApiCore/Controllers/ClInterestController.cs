using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HelperBess.WebApiCore.Controllers
{
    //////[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]
    public class ClInterestController : ControllerBase
    {
        private readonly IClInterestService ClInterestServiceService;
        public ClInterestController(IClInterestService iClInterestService)
        {
            ClInterestServiceService = iClInterestService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClInterest/GetClInterest")]
        public IActionResult GetClInterest()
        {
            try
            {
                List<ClInterest> interests = ClInterestServiceService.GetClInterest().ToList();

                if (interests != null && interests.Any())
                {
                    return Ok(interests);
                }
                else
                {
                    return BadRequest("No interest(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClInterest/AddClInterest")]
        public IActionResult AddClInterest(ClInterest ClInterest)
        {
            try
            {
                ClInterest interest = ClInterestServiceService.AddClInterest(ClInterest);

                if (interest != null)
                {
                    return Ok(interest);
                }
                else
                {
                    return BadRequest("Failed to add interest.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClInterest/UpdateClInterest")]
        public IActionResult UpdateClInterest(ClInterest ClInterest)
        {
            try
            {
                ClInterest currentInterest = ClInterestServiceService.GetClInterestById(ClInterest.InterestsId);

                if (currentInterest != null)
                {
                    #region Interest to update

                    currentInterest.InterestsId = ClInterest.InterestsId;
                    currentInterest.InterestsDescription = ClInterest.InterestsDescription;

                    #endregion

                    ClInterest interest = ClInterestServiceService.UpdateClInterest(currentInterest);

                    if (interest != null)
                    {
                        return Ok(interest);
                    }
                    else
                    {
                        return BadRequest("Failed to update interest.");
                    }
                }
                else
                {
                    return BadRequest("Interest not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClInterest/DeleteClInterest")]
        public IActionResult DeleteClInterest(int id)
        {
            try
            {
                ClInterest currentInterest = ClInterestServiceService.GetClInterestById(id);

                if (currentInterest != null)
                {
                    ClInterest interest = ClInterestServiceService.DeleteClInterest(id);

                    return Ok(interest);
                }
                else
                {
                    return BadRequest("Interest not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClInterest/GetClInterestById")]
        public IActionResult GetClInterestById(int id)
        {
            try
            {
                ClInterest interest = ClInterestServiceService.GetClInterestById(id);

                if (interest != null)
                {
                    return Ok(interest);
                }
                else
                {
                    return BadRequest("Interest not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
