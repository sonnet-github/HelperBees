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
    public class SwSupportWorkerOtherQualificationController : ControllerBase
    {
        private readonly ISwSupportWorkerOtherQualificationService SwSupportWorkerOtherQualificationServiceService;
        public SwSupportWorkerOtherQualificationController(ISwSupportWorkerOtherQualificationService iSwSupportWorkerOtherQualificationService)
        {
            SwSupportWorkerOtherQualificationServiceService = iSwSupportWorkerOtherQualificationService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerOtherQualification/GetSwSupportWorkerOtherQualification")]
        public IActionResult GetSwSupportWorkerOtherQualification()
        {
            try
            {
                List<SwSupportWorkerOtherQualification> swQualifications = SwSupportWorkerOtherQualificationServiceService.GetSwSupportWorkerOtherQualification().ToList();

                if (swQualifications != null && swQualifications.Any())
                {
                    return Ok(swQualifications);
                }
                else
                {
                    return BadRequest("No support worker other qualification(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerOtherQualification/AddSwSupportWorkerOtherQualification")]
        public IActionResult AddSwSupportWorkerOtherQualification(SwSupportWorkerOtherQualification SwSupportWorkerOtherQualification)
        {
            try
            {
                SwSupportWorkerOtherQualification swQualification = SwSupportWorkerOtherQualificationServiceService.AddSwSupportWorkerOtherQualification(SwSupportWorkerOtherQualification);

                if (swQualification != null)
                {
                    return Ok(swQualification);
                }
                else
                {
                    return BadRequest("Failed to add support worker other qualification.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerOtherQualification/UpdateSwSupportWorkerOtherQualification")]
        public IActionResult UpdateSwSupportWorkerOtherQualification(SwSupportWorkerOtherQualification SwSupportWorkerOtherQualification)
        {
            try
            {
                SwSupportWorkerOtherQualification swCurrentQualification = SwSupportWorkerOtherQualificationServiceService.GetSwSupportWorkerOtherQualificationById(SwSupportWorkerOtherQualification.SupportWorkerOtherQualificationId);

                if (swCurrentQualification != null)
                {
                    swCurrentQualification.SupportWorkerOtherQualificationId = SwSupportWorkerOtherQualification.SupportWorkerOtherQualificationId;
                    swCurrentQualification.SupportWorkerId = SwSupportWorkerOtherQualification.SupportWorkerId;
                    swCurrentQualification.ServiceGroupId = SwSupportWorkerOtherQualification.SupportWorkerOtherQualificationId;
                    swCurrentQualification.OtherQualification = SwSupportWorkerOtherQualification.OtherQualification;
                    swCurrentQualification.Certificate = SwSupportWorkerOtherQualification.Certificate;

                    SwSupportWorkerOtherQualification swQualification = SwSupportWorkerOtherQualificationServiceService.UpdateSwSupportWorkerOtherQualification(swCurrentQualification);

                    if (swQualification != null)
                    {
                        return Ok(swQualification);
                    }
                    else
                    {
                        return BadRequest("Failed to update support worker other qualification.");
                    }
                }
                else
                {
                    return BadRequest("Support worker other qualification not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerOtherQualification/DeleteSwSupportWorkerOtherQualification")]
        public IActionResult DeleteSwSupportWorkerOtherQualification(int id)
        {
            try
            {
                SwSupportWorkerOtherQualification swCurrentQualification = SwSupportWorkerOtherQualificationServiceService.GetSwSupportWorkerOtherQualificationById(id);

                if (swCurrentQualification != null)
                {
                    SwSupportWorkerOtherQualification swQualification = SwSupportWorkerOtherQualificationServiceService.DeleteSwSupportWorkerOtherQualification(id);

                    return Ok(swQualification);
                }
                else
                {
                    return BadRequest("Support worker other qualification not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerOtherQualification/GetSwSupportWorkerOtherQualificationById")]
        public IActionResult GetSwSupportWorkerOtherQualificationById(int id)
        {
            try
            {
                SwSupportWorkerOtherQualification swQualification = SwSupportWorkerOtherQualificationServiceService.GetSwSupportWorkerOtherQualificationById(id);

                if (swQualification != null)
                {
                    return Ok(swQualification);
                }
                else
                {
                    return BadRequest("Support worker other qualification not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerOtherQualification/GetSwSupportWorkerOtherQualificationBySupportWorkerId")]
        public IActionResult GetSwSupportWorkerOtherQualificationBySupportWorkerId(int supportWorkerId)
        {
            try
            {
                List<SwSupportWorkerOtherQualification> swQualifications = SwSupportWorkerOtherQualificationServiceService.GetSwSupportWorkerOtherQualificationBySupportWorkerId(supportWorkerId)?.ToList();

                if (swQualifications != null && swQualifications.Any())
                {
                    return Ok(swQualifications);
                }
                else
                {
                    return NotFound("Support worker other qualification not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
