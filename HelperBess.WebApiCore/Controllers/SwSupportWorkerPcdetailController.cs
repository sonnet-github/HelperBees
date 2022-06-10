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
    public class SwSupportWorkerPcdetailController : Controller
    {
        private readonly ISwSupportWorkerPcdetailService SwSupportWorkerPcdetailServiceService;
        public SwSupportWorkerPcdetailController(ISwSupportWorkerPcdetailService iSwSupportWorkerPcdetailService)
        {
            SwSupportWorkerPcdetailServiceService = iSwSupportWorkerPcdetailService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerPcdetail/GetSwSupportWorkerPcdetail")]
        public IActionResult GetSwSupportWorkerPcdetail()
        {
            try
            {
                List<SwSupportWorkerPcdetail> swPcDetails = SwSupportWorkerPcdetailServiceService.GetSwSupportWorkerPcdetail().ToList();

                if (swPcDetails != null && swPcDetails.Any())
                {
                    return Ok(swPcDetails);
                }
                else
                {
                    return BadRequest("No support worker PC detail(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerPcdetail/AddSwSupportWorkerPcdetail")]
        public IActionResult AddSwSupportWorkerPcdetail(SwSupportWorkerPcdetail SwSupportWorkerPcdetail)
        {
            try
            {
                SwSupportWorkerPcdetail swPcdetail = SwSupportWorkerPcdetailServiceService.AddSwSupportWorkerPcdetail(SwSupportWorkerPcdetail);

                if (swPcdetail != null)
                {
                    return Ok(swPcdetail);
                }
                else
                {
                    return BadRequest("Failed to add support worker PC detail.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerPcdetail/UpdateSwSupportWorkerPcdetail")]
        public IActionResult UpdateSwSupportWorkerPcdetail(SwSupportWorkerPcdetail SwSupportWorkerPcdetail)
        {
            try
            {
                SwSupportWorkerPcdetail swCurrentPcDetail = SwSupportWorkerPcdetailServiceService.GetSwSupportWorkerPcdetailById(SwSupportWorkerPcdetail.SupportWorkerPcdetailsId);

                if (swCurrentPcDetail != null)
                {
                    swCurrentPcDetail.SupportWorkerPcdetailsId = SwSupportWorkerPcdetail.SupportWorkerPcdetailsId;
                    swCurrentPcDetail.SupportWorkerId = SwSupportWorkerPcdetail.SupportWorkerId;
                    swCurrentPcDetail.TwoPlusYearsConfirmation = SwSupportWorkerPcdetail.TwoPlusYearsConfirmation;

                    SwSupportWorkerPcdetail swPcDetail = SwSupportWorkerPcdetailServiceService.UpdateSwSupportWorkerPcdetail(swCurrentPcDetail);

                    if (swPcDetail != null)
                    {
                        return Ok(swPcDetail);
                    }
                    else
                    {
                        return BadRequest("Failed to update support worker PC detail.");
                    }
                }
                else
                {
                    return BadRequest("Support worker PC detail not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerPcdetail/DeleteSwSupportWorkerPcdetail")]
        public IActionResult DeleteSwSupportWorkerPcdetail(int id)
        {
            try
            {
                SwSupportWorkerPcdetail swCurrentPcdetail = SwSupportWorkerPcdetailServiceService.GetSwSupportWorkerPcdetailById(id);

                if (swCurrentPcdetail != null)
                {
                    SwSupportWorkerPcdetail swPcdetail = SwSupportWorkerPcdetailServiceService.DeleteSwSupportWorkerPcdetail(id);

                    return Ok(swPcdetail);
                }
                else
                {
                    return BadRequest("Support worker PC detail not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerPcdetail/GetSwSupportWorkerPcdetailById")]
        public IActionResult GetSwSupportWorkerPcdetailById(int id)
        {
            try
            {
                SwSupportWorkerPcdetail swPcdetail = SwSupportWorkerPcdetailServiceService.GetSwSupportWorkerPcdetailById(id);

                if (swPcdetail != null)
                {
                    return Ok(swPcdetail);
                }
                else
                {
                    return BadRequest("Support worker PC detail not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerPcdetail/GetSwSupportWorkerPcdetailBySupportWorkerId")]
        public IActionResult GetSwSupportWorkerPcdetailBySupportWorkerId(int supportWorkerId)
        {
            try
            {
                List<SwSupportWorkerPcdetail> swPcdetails = SwSupportWorkerPcdetailServiceService.GetSwSupportWorkerPcdetailBySupportWorkerId(supportWorkerId)?.ToList();

                if (swPcdetails != null && swPcdetails.Any())
                {
                    return Ok(swPcdetails);
                }
                else
                {
                    return NotFound("Support worker PC detail not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
