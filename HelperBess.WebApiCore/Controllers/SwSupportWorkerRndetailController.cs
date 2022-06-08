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
    public class SwSupportWorkerRndetailController : Controller
    {
        private readonly ISwSupportWorkerRndetailService SwSupportWorkerRndetailServiceService;
        public SwSupportWorkerRndetailController(ISwSupportWorkerRndetailService iSwSupportWorkerRndetailService)
        {
            SwSupportWorkerRndetailServiceService = iSwSupportWorkerRndetailService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerRndetail/GetSwSupportWorkerRndetail")]
        public IActionResult GetSwSupportWorkerRndetail()
        {
            try
            {
                List<SwSupportWorkerRndetail> swRndetails = SwSupportWorkerRndetailServiceService.GetSwSupportWorkerRndetail().ToList();

                if (swRndetails != null && swRndetails.Any())
                {
                    return Ok(swRndetails);
                }
                else
                {
                    return BadRequest("No support worker RN detail(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerRndetail/AddSwSupportWorkerRndetail")]
        public IActionResult AddSwSupportWorkerRndetail(SwSupportWorkerRndetail SwSupportWorkerRndetail)
        {
            try
            {
                SwSupportWorkerRndetail swRndetail = SwSupportWorkerRndetailServiceService.AddSwSupportWorkerRndetail(SwSupportWorkerRndetail);

                if (swRndetail != null)
                {
                    return Ok(swRndetail);
                }
                else
                {
                    return BadRequest("Failed to add support worker RN detail.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerRndetail/UpdateSwSupportWorkerRndetail")]
        public IActionResult UpdateSwSupportWorkerRndetail(SwSupportWorkerRndetail SwSupportWorkerRndetail)
        {
            try
            {
                SwSupportWorkerRndetail swCurrentRndetail = SwSupportWorkerRndetailServiceService.GetSwSupportWorkerRndetailById(SwSupportWorkerRndetail.SupportWorkerRndetailsId);

                if (swCurrentRndetail != null)
                {
                    #region RN Detail to update

                    swCurrentRndetail.SupportWorkerRndetailsId = SwSupportWorkerRndetail.SupportWorkerRndetailsId;
                    swCurrentRndetail.SupportWorkerId = SwSupportWorkerRndetail.SupportWorkerId;
                    swCurrentRndetail.OnePlusYearsConfirmation = SwSupportWorkerRndetail.OnePlusYearsConfirmation;
                    swCurrentRndetail.YearsExperience = SwSupportWorkerRndetail.YearsExperience;
                    swCurrentRndetail.NursingMidwiferyReqConfirm = SwSupportWorkerRndetail.NursingMidwiferyReqConfirm;
                    swCurrentRndetail.AhpraregistrationActiveConfirm = SwSupportWorkerRndetail.AhpraregistrationActiveConfirm;
                    swCurrentRndetail.ConfirmNoComplaints = SwSupportWorkerRndetail.ConfirmNoComplaints;
                    swCurrentRndetail.ComplaintDetails = SwSupportWorkerRndetail.ComplaintDetails;

                    #endregion

                    SwSupportWorkerRndetail swRndetail = SwSupportWorkerRndetailServiceService.UpdateSwSupportWorkerRndetail(swCurrentRndetail);

                    if (swRndetail != null)
                    {
                        return Ok(swRndetail);
                    }
                    else
                    {
                        return BadRequest("Failed to update support worker RN detail.");
                    }
                }
                else
                {
                    return BadRequest("Support worker RN detail not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerRndetail/DeleteSwSupportWorkerRndetail")]
        public IActionResult DeleteSwSupportWorkerRndetail(int id)
        {
            try
            {
                SwSupportWorkerRndetail swCurrentRndetail = SwSupportWorkerRndetailServiceService.GetSwSupportWorkerRndetailById(id);

                if (swCurrentRndetail != null)
                {
                    SwSupportWorkerRndetail swRndetail = SwSupportWorkerRndetailServiceService.DeleteSwSupportWorkerRndetail(id);

                    return Ok(swRndetail);
                }
                else
                {
                    return BadRequest("Support worker RN detail not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerRndetail/GetSwSupportWorkerRndetailById")]
        public IActionResult GetSwSupportWorkerRndetailById(int id)
        {
            try
            {
                SwSupportWorkerRndetail swRndetail = SwSupportWorkerRndetailServiceService.GetSwSupportWorkerRndetailById(id);

                if (swRndetail != null)
                {
                    return Ok(swRndetail);
                }
                else
                {
                    return BadRequest("Support worker RN detail not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
