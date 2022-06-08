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
    public class SwSupportWorkerQualificationController : ControllerBase
    {
        private readonly ISwSupportWorkerQualificationService SwSupportWorkerQualificationServiceService;
        public SwSupportWorkerQualificationController(ISwSupportWorkerQualificationService iSwSupportWorkerQualificationService)
        {
            SwSupportWorkerQualificationServiceService = iSwSupportWorkerQualificationService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerQualification/GetSwSupportWorkerQualification")]
        public IActionResult GetSwSupportWorkerQualification()
        {
            try
            {
                List<SwSupportWorkerQualification> swQualifications = SwSupportWorkerQualificationServiceService.GetSwSupportWorkerQualification().ToList();

                if (swQualifications != null && swQualifications.Any())
                {
                    return Ok(swQualifications);
                }
                else
                {
                    return BadRequest("No support worker qualification(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerQualification/AddSwSupportWorkerQualification")]
        public IActionResult AddSwSupportWorkerQualification(SwSupportWorkerQualification SwSupportWorkerQualification)
        {
            try
            {
                SwSupportWorkerQualification swQualification = SwSupportWorkerQualificationServiceService.AddSwSupportWorkerQualification(SwSupportWorkerQualification);

                if (swQualification != null)
                {
                    return Ok(swQualification);
                }
                else
                {
                    return BadRequest("Failed to add support worker qualification.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerQualification/UpdateSwSupportWorkerQualification")]
        public IActionResult UpdateSwSupportWorkerQualification(SwSupportWorkerQualification SwSupportWorkerQualification)
        {
            try
            {
                SwSupportWorkerQualification swCurrentQualification = SwSupportWorkerQualificationServiceService.GetSwSupportWorkerQualificationById(SwSupportWorkerQualification.SupportWorkerQualificationId);

                if (swCurrentQualification != null)
                {
                    #region Qualification to update

                    swCurrentQualification.SupportWorkerQualificationId = SwSupportWorkerQualification.SupportWorkerQualificationId;
                    swCurrentQualification.SupportWorkerId = SwSupportWorkerQualification.SupportWorkerId;
                    swCurrentQualification.QualificationId = SwSupportWorkerQualification.QualificationId;
                    swCurrentQualification.Certificate = SwSupportWorkerQualification.Certificate;
                    swCurrentQualification.AcquiredDate = SwSupportWorkerQualification.AcquiredDate;
                    swCurrentQualification.ExpiryDate = SwSupportWorkerQualification.ExpiryDate;
                    swCurrentQualification.ExperienceYears = SwSupportWorkerQualification.ExperienceYears;
                    swCurrentQualification.ConfirmBoardRequirements = SwSupportWorkerQualification.ConfirmBoardRequirements;
                    swCurrentQualification.ConfirmNoBoardComplaints = SwSupportWorkerQualification.ConfirmNoBoardComplaints;
                    swCurrentQualification.ComplaintDetails = SwSupportWorkerQualification.ComplaintDetails;

                    #endregion

                    SwSupportWorkerQualification swQualification = SwSupportWorkerQualificationServiceService.UpdateSwSupportWorkerQualification(swCurrentQualification);

                    if (swQualification != null)
                    {
                        return Ok(swQualification);
                    }
                    else
                    {
                        return BadRequest("Failed to update support worker qualification.");
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
        [Route("api/SwSupportWorkerQualification/DeleteSwSupportWorkerQualification")]
        public IActionResult DeleteSwSupportWorkerQualification(int id)
        {
            try
            {
                SwSupportWorkerQualification swCurrentQualification = SwSupportWorkerQualificationServiceService.GetSwSupportWorkerQualificationById(id);

                if (swCurrentQualification != null)
                {
                    SwSupportWorkerQualification swQualification = SwSupportWorkerQualificationServiceService.DeleteSwSupportWorkerQualification(id);

                    return Ok(swQualification);
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

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerQualification/GetSwSupportWorkerQualificationById")]
        public IActionResult GetSwSupportWorkerQualificationById(int id)
        {
            try
            {
                SwSupportWorkerQualification swQualification = SwSupportWorkerQualificationServiceService.GetSwSupportWorkerQualificationById(id);

                if (swQualification != null)
                {
                    return Ok(swQualification);
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
    }
}
