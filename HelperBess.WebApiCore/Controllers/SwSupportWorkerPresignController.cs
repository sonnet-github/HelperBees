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
    public class SwSupportWorkerPresignController : ControllerBase
    {
        private readonly ISwSupportWorkerPresignService SwSupportWorkerPresignServiceService;
        public SwSupportWorkerPresignController(ISwSupportWorkerPresignService iSwSupportWorkerPresignService)
        {
            SwSupportWorkerPresignServiceService = iSwSupportWorkerPresignService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerPresign/GetSwSupportWorkerPresign")]
        public IActionResult GetSwSupportWorkerPresign()
        {
            try
            {
                List<SwSupportWorkerPresign> swPresigns = SwSupportWorkerPresignServiceService.GetSwSupportWorkerPresign().ToList();

                if (swPresigns != null && swPresigns.Any())
                {
                    return Ok(swPresigns);
                }
                else
                {
                    return BadRequest("No support worker presign(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerPresign/AddSwSupportWorkerPresign")]
        public IActionResult AddSwSupportWorkerPresign(SwSupportWorkerPresign SwSupportWorkerPresign)
        {
            try
            {
                SwSupportWorkerPresign swPresign = SwSupportWorkerPresignServiceService.AddSwSupportWorkerPresign(SwSupportWorkerPresign);

                if (swPresign != null)
                {
                    return Ok(swPresign);
                }
                else
                {
                    return BadRequest("Failed to add support worker presign.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerPresign/UpdateSwSupportWorkerPresign")]
        public IActionResult UpdateSwSupportWorkerPresign(SwSupportWorkerPresign SwSupportWorkerPresign)
        {
            try
            {
                SwSupportWorkerPresign swCurrentPresign = SwSupportWorkerPresignServiceService.GetSwSupportWorkerPresignById(SwSupportWorkerPresign.SupportWorkerPresignId);

                if (swCurrentPresign != null)
                {
                    swCurrentPresign.SupportWorkerPresignId = SwSupportWorkerPresign.SupportWorkerPresignId;
                    swCurrentPresign.SupportWorkerId = SwSupportWorkerPresign.SupportWorkerId;
                    swCurrentPresign.Firstname = SwSupportWorkerPresign.Firstname;
                    swCurrentPresign.Lastname = SwSupportWorkerPresign.Lastname;
                    swCurrentPresign.Location = SwSupportWorkerPresign.Location;
                    swCurrentPresign.WorkHours = SwSupportWorkerPresign.WorkHours;
                    swCurrentPresign.MobileNumber = SwSupportWorkerPresign.MobileNumber;
                    swCurrentPresign.HowHear = SwSupportWorkerPresign.HowHear;
                    swCurrentPresign.SensitiveDataConfirm = SwSupportWorkerPresign.SensitiveDataConfirm;
                    swCurrentPresign.MarketingOptin = SwSupportWorkerPresign.MarketingOptin;
                    swCurrentPresign.TermsAndConditionsConfirm = SwSupportWorkerPresign.TermsAndConditionsConfirm;

                    SwSupportWorkerPresign swPresign = SwSupportWorkerPresignServiceService.UpdateSwSupportWorkerPresign(swCurrentPresign);

                    if (swPresign != null)
                    {
                        return Ok(swPresign);
                    }
                    else
                    {
                        return BadRequest("Failed to update support worker presign.");
                    }
                }
                else
                {
                    return BadRequest("Support worker presign not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerPresign/DeleteSwSupportWorkerPresign")]
        public IActionResult DeleteSwSupportWorkerPresign(int id)
        {
            try
            {
                SwSupportWorkerPresign swCurrentPresign = SwSupportWorkerPresignServiceService.GetSwSupportWorkerPresignById(id);

                if (swCurrentPresign != null)
                {
                    SwSupportWorkerPresign swPresign = SwSupportWorkerPresignServiceService.DeleteSwSupportWorkerPresign(id);

                    return Ok(swPresign);
                }
                else
                {
                    return BadRequest("Support worker presign not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerPresign/GetSwSupportWorkerPresignById")]
        public IActionResult GetSwSupportWorkerPresignById(int id)
        {
            try
            {
                SwSupportWorkerPresign swPresign = SwSupportWorkerPresignServiceService.GetSwSupportWorkerPresignById(id);

                if (swPresign != null)
                {
                    return Ok(swPresign);
                }
                else
                {
                    return BadRequest("Support worker presign not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerPresign/GetSwSupportWorkerPresignBySupportWorkerId")]
        public IActionResult GetSwSupportWorkerPresignBySupportWorkerId(int supportWorkerId)
        {
            try
            {
                List<SwSupportWorkerPresign> swPresigns = SwSupportWorkerPresignServiceService.GetSwSupportWorkerPresignBySupportWorkerId(supportWorkerId)?.ToList();

                if (swPresigns != null && swPresigns.Any())
                {
                    return Ok(swPresigns);
                }
                else
                {
                    return NotFound("Support worker presign not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
