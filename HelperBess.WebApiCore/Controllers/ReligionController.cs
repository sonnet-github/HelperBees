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
    public class ReligionController : ControllerBase
    {
        private readonly IReligionService ReligionServiceService;
        public ReligionController(IReligionService iReligionService)
        {
            ReligionServiceService = iReligionService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Religion/GetReligion")]
        public IActionResult GetReligion()
        {
            try
            {
                List<Religion> religions = ReligionServiceService.GetReligion().ToList();

                if (religions != null && religions.Any())
                {
                    return Ok(religions);
                }
                else
                {
                    return BadRequest("No religion(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Religion/AddReligion")]
        public IActionResult AddReligion(Religion Religion)
        {
            try
            {
                Religion religion = ReligionServiceService.AddReligion(Religion);

                if (religion != null)
                {
                    return Ok(religion);
                }
                else
                {
                    return BadRequest("Failed to add religion.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/Religion/UpdateReligion")]
        public IActionResult UpdateReligion(Religion Religion)
        {
            try
            {
                Religion currentReligion = ReligionServiceService.GetReligionById(Religion.ReligionId);

                if (currentReligion != null)
                {
                    #region Religion to update

                    currentReligion.ReligionId = Religion.ReligionId;
                    currentReligion.Religion1 = Religion.Religion1;
                    currentReligion.DisplayOrder = Religion.DisplayOrder;

                    #endregion

                    Religion religion = ReligionServiceService.UpdateReligion(currentReligion);

                    if (religion != null)
                    {
                        return Ok(religion);
                    }
                    else
                    {
                        return BadRequest("Failed to update religion.");
                    }
                }
                else
                {
                    return BadRequest("Religion not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Religion/DeleteReligion")]
        public IActionResult DeleteReligion(int id)
        {
            try
            {
                Religion currentReligion = ReligionServiceService.GetReligionById(id);

                if (currentReligion != null)
                {
                    Religion religion = ReligionServiceService.DeleteReligion(id);

                    return Ok(religion);
                }
                else
                {
                    return BadRequest("Religion not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Religion/GetReligionById")]
        public IActionResult GetReligionById(int id)
        {
            try
            {
                Religion religion = ReligionServiceService.GetReligionById(id);

                if (religion != null)
                {
                    return Ok(religion);
                }
                else
                {
                    return BadRequest("Religion not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
