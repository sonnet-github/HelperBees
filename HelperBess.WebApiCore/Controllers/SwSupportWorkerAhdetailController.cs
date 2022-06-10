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
    public class SwSupportWorkerAhdetailController : ControllerBase
    {
        private readonly ISwSupportWorkerAhdetailService SwSupportWorkerAhdetailServiceService;
        public SwSupportWorkerAhdetailController(ISwSupportWorkerAhdetailService iSwSupportWorkerAhdetailService)
        {
            SwSupportWorkerAhdetailServiceService = iSwSupportWorkerAhdetailService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerAhdetail/GetSwSupportWorkerAhdetail")]
        public IActionResult GetSwSupportWorkerAhdetail()
        {
            try
            {
                List<SwSupportWorkerAhdetail> swAhDetails = SwSupportWorkerAhdetailServiceService.GetSwSupportWorkerAhdetail().ToList();

                if (swAhDetails != null && swAhDetails.Any())
                {
                    return Ok(swAhDetails);
                }
                else
                {
                    return BadRequest("No support worker AH detail(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerAhdetail/AddSwSupportWorkerAhdetail")]
        public IActionResult AddSwSupportWorkerAhdetail(SwSupportWorkerAhdetail SwSupportWorkerAhdetail)
        {
            try
            {
                SwSupportWorkerAhdetail swAhDetail = SwSupportWorkerAhdetailServiceService.AddSwSupportWorkerAhdetail(SwSupportWorkerAhdetail);

                if (swAhDetail != null)
                {
                    return Ok(swAhDetail);
                }
                else
                {
                    return BadRequest("Failed to add support worker AH detail.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerAhdetail/UpdateSwSupportWorkerAhdetail")]
        public IActionResult UpdateSwSupportWorkerAhdetail(SwSupportWorkerAhdetail SwSupportWorkerAhdetail)
        {
            try
            {
                SwSupportWorkerAhdetail swCurrentAhDetail = SwSupportWorkerAhdetailServiceService.GetSwSupportWorkerAhdetailById(SwSupportWorkerAhdetail.SupportWorkerAhdetailsId);

                if (swCurrentAhDetail != null)
                {
                    swCurrentAhDetail.SupportWorkerAhdetailsId = SwSupportWorkerAhdetail.SupportWorkerAhdetailsId;
                    swCurrentAhDetail.SupportWorkerId = SwSupportWorkerAhdetail.SupportWorkerId;
                    swCurrentAhDetail.OccupationalTherapyExperience = SwSupportWorkerAhdetail.OccupationalTherapyExperience;

                    SwSupportWorkerAhdetail swAhDetail = SwSupportWorkerAhdetailServiceService.UpdateSwSupportWorkerAhdetail(swCurrentAhDetail);

                    if (swAhDetail != null)
                    {
                        return Ok(swAhDetail);
                    }
                    else
                    {
                        return BadRequest("Failed to update support worker AH detail.");
                    }
                }
                else
                {
                    return BadRequest("Support worker AH detail not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerAhdetail/DeleteSwSupportWorkerAhdetail")]
        public IActionResult DeleteSwSupportWorkerAhdetail(int id)
        {   
            try
            {
                SwSupportWorkerAhdetail swCurrentAhDetail = SwSupportWorkerAhdetailServiceService.GetSwSupportWorkerAhdetailById(id);

                if (swCurrentAhDetail != null)
                {
                    SwSupportWorkerAhdetail swAhDetail = SwSupportWorkerAhdetailServiceService.DeleteSwSupportWorkerAhdetail(id);

                    return Ok(swAhDetail);
                }
                else
                {
                    return BadRequest("Support worker AH detail not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerAhdetail/GetSwSupportWorkerAhdetailById")]
        public IActionResult GetSwSupportWorkerAhdetailById(int id)
        {
            try
            {
                SwSupportWorkerAhdetail swAhDetail = SwSupportWorkerAhdetailServiceService.GetSwSupportWorkerAhdetailById(id);

                if (swAhDetail != null)
                {
                    return Ok(swAhDetail);
                }
                else
                {
                    return BadRequest("Support worker AH detail not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerAhdetail/GetSwSupportWorkerAhdetailBySupportWorkerId")]
        public IActionResult GetSwSupportWorkerAhdetailBySupportWorkerId(int supportWorkerId)
        {
            try
            {
                List<SwSupportWorkerAhdetail> swAhDetails = SwSupportWorkerAhdetailServiceService
                                                                .GetSwSupportWorkerAhdetailBySupportWorkerId(supportWorkerId)?
                                                                .ToList();

                if (swAhDetails != null && swAhDetails.Any())
                {
                    return Ok(swAhDetails);
                }
                else
                {
                    return NotFound("Support worker AH detail not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
