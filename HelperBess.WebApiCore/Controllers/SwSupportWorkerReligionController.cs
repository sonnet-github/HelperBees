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
    public class SwSupportWorkerReligionController : ControllerBase
    {
        private readonly ISwSupportWorkerReligionService SwSupportWorkerReligionServiceService;
        public SwSupportWorkerReligionController(ISwSupportWorkerReligionService iSwSupportWorkerReligionService)
        {
            SwSupportWorkerReligionServiceService = iSwSupportWorkerReligionService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerReligion/GetSwSupportWorkerReligion")]
        public IActionResult GetSwSupportWorkerReligion()
        {
            try
            {
                List<SwSupportWorkerReligion> swReligions = SwSupportWorkerReligionServiceService.GetSwSupportWorkerReligion().ToList();

                if (swReligions != null && swReligions.Any())
                {
                    return Ok(swReligions);
                }
                else
                {
                    return BadRequest("No support worker religion(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerReligion/AddSwSupportWorkerReligion")]
        public IActionResult AddSwSupportWorkerReligion(SwSupportWorkerReligion SwSupportWorkerReligion)
        {
            try
            {
                SwSupportWorkerReligion swReligion = SwSupportWorkerReligionServiceService.AddSwSupportWorkerReligion(SwSupportWorkerReligion);

                if (swReligion != null)
                {
                    return Ok(swReligion);
                }
                else
                {
                    return BadRequest("Failed to add support worker religion.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerReligion/UpdateSwSupportWorkerReligion")]
        public IActionResult UpdateSwSupportWorkerReligion(SwSupportWorkerReligion SwSupportWorkerReligion)
        {
            try
            {
                SwSupportWorkerReligion swCurrentReligion = SwSupportWorkerReligionServiceService.GetSwSupportWorkerReligionById(SwSupportWorkerReligion.SupportWorkerReligionId);

                if (swCurrentReligion != null)
                {
                    #region Religion to update

                    swCurrentReligion.SupportWorkerReligionId = SwSupportWorkerReligion.SupportWorkerReligionId;
                    swCurrentReligion.SupportWorkerId = SwSupportWorkerReligion.SupportWorkerId;
                    swCurrentReligion.ReligionId = SwSupportWorkerReligion.ReligionId;

                    #endregion

                    SwSupportWorkerReligion swReligion = SwSupportWorkerReligionServiceService.UpdateSwSupportWorkerReligion(swCurrentReligion);

                    if (swReligion != null)
                    {
                        return Ok(swReligion);
                    }
                    else
                    {
                        return BadRequest("Failed to update support worker religion.");
                    }
                }
                else
                {
                    return BadRequest("Support worker qualification not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerReligion/DeleteSwSupportWorkerReligion")]
        public IActionResult DeleteSwSupportWorkerReligion(int id)
        {
            try
            {
                SwSupportWorkerReligion swCurrentReligion = SwSupportWorkerReligionServiceService.GetSwSupportWorkerReligionById(id);

                if (swCurrentReligion != null)
                {
                    SwSupportWorkerReligion swReligion = SwSupportWorkerReligionServiceService.DeleteSwSupportWorkerReligion(id);

                    return Ok(swReligion);
                }
                else
                {
                    return BadRequest("Support worker religion not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerReligion/GetSwSupportWorkerReligionById")]
        public IActionResult GetSwSupportWorkerReligionById(int id)
        {
            try
            {
                SwSupportWorkerReligion swReligion = SwSupportWorkerReligionServiceService.GetSwSupportWorkerReligionById(id);

                if (swReligion != null)
                {
                    return Ok(swReligion);
                }
                else
                {
                    return BadRequest("Support worker religion not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
