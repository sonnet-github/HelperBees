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
    public class SwAvailabilityDetailController : ControllerBase
    {
        private readonly ISwAvailabilityDetailService SwAvailabilityDetailServiceService;
        public SwAvailabilityDetailController(ISwAvailabilityDetailService iSwAvailabilityDetailService)
        {
            SwAvailabilityDetailServiceService = iSwAvailabilityDetailService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwAvailabilityDetail/GetSwAvailabilityDetail")]
        public IActionResult GetSwAvailabilityDetail()
        {
            try
            {
                List<SwAvailabilityDetail> availabilityDetails = SwAvailabilityDetailServiceService.GetSwAvailabilityDetail().ToList();

                if (availabilityDetails != null && availabilityDetails.Any())
                {
                    return Ok(availabilityDetails);
                }
                else
                {
                    return BadRequest("No support worker availability Detail(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwAvailabilityDetail/DeleteSwAvailabilityDetailbySupportWorkerId")]
        public IActionResult DeleteSwAvailabilityDetailbySupportWorkerId(int SupportWorkerId)
        {
            try
            {
                List<SwAvailabilityDetail> swAvailabilityDetail = SwAvailabilityDetailServiceService.GetSwAvailabilityDetailbySupportWorkerId(SupportWorkerId).ToList();

                if (swAvailabilityDetail != null)
                {
                    List<SwAvailabilityDetail> swAvailabilityDetailx = SwAvailabilityDetailServiceService.DeleteSwAvailabilityDetailbySupportWorkerId(SupportWorkerId).ToList();

                    return Ok(swAvailabilityDetailx);
                }
                else
                {
                    return BadRequest("Support Worker Id not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwAvailabilityDetail/GetSwAvailabilityDetailbySupportWorkerId")]
        public IActionResult GetSwAvailabilityDetailbySupportWorkerId(int supportWorkerId)
        {
            try
            {
                List<SwAvailabilityDetail> swAvailabilityDetail = SwAvailabilityDetailServiceService.GetSwAvailabilityDetailbySupportWorkerId(supportWorkerId)?.ToList();

                if (swAvailabilityDetail != null && swAvailabilityDetail.Any())
                {
                    return Ok(swAvailabilityDetail);
                }
                else
                {
                    return NotFound("Support worker Id not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        [Route("[action]")]
        [Route("api/SwAvailabilityDetail/AddSwAvailabilityDetail")]
        public IActionResult AddSwAvailabilityDetail(SwAvailabilityDetail SwAvailabilityDetail)
        {
            try
            {
                SwAvailabilityDetail availabilityDetail = SwAvailabilityDetailServiceService.AddSwAvailabilityDetail(SwAvailabilityDetail);

                if (availabilityDetail != null)
                {
                    return Ok(availabilityDetail);
                }
                else
                {
                    return BadRequest("Failed to add support worker availability detail.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwAvailabilityDetail/UpdateSwAvailabilityDetail")]
        public IActionResult UpdateSwAvailabilityDetail(SwAvailabilityDetail SwAvailabilityDetail)
        {
            try
            {
                SwAvailabilityDetail currentAvailabilityDetail = SwAvailabilityDetailServiceService.GetSwAvailabilityDetailById(SwAvailabilityDetail.AvailabilityDetailsId);

                if (currentAvailabilityDetail != null)
                {
                    #region Availability Detail to update

                    currentAvailabilityDetail.AvailabilityDetailsId = SwAvailabilityDetail.AvailabilityDetailsId;
                    currentAvailabilityDetail.SupportWorkerId = SwAvailabilityDetail.SupportWorkerId;
                    currentAvailabilityDetail.DayOfWeek = SwAvailabilityDetail.DayOfWeek;
                    currentAvailabilityDetail.StartTime = SwAvailabilityDetail.StartTime;
                    currentAvailabilityDetail.EndTime = SwAvailabilityDetail.EndTime;

                    #endregion

                    SwAvailabilityDetail availabilityDetail = SwAvailabilityDetailServiceService.UpdateSwAvailabilityDetail(currentAvailabilityDetail);

                    if (availabilityDetail != null)
                    {
                        return Ok(availabilityDetail);
                    }
                    else
                    {
                        return BadRequest("Failed to update support worker availability detail.");
                    }
                }
                else
                {
                    return BadRequest("Support worker availability detail not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwAvailabilityDetail/DeleteSwAvailabilityDetail")]
        public IActionResult DeleteSwAvailabilityDetail(int id)
        {
            try
            {
                SwAvailabilityDetail currentAvailabilityDetail = SwAvailabilityDetailServiceService.GetSwAvailabilityDetailById(id);

                if (currentAvailabilityDetail != null)
                {
                    SwAvailabilityDetail availabilityDetail = SwAvailabilityDetailServiceService.DeleteSwAvailabilityDetail(id);

                    return Ok(availabilityDetail);
                }
                else
                {
                    return BadRequest("Support worker availability detail not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwAvailabilityDetail/GetSwAvailabilityDetailById")]
        public IActionResult GetSwAvailabilityDetailById(int id)
        {
            try
            {
                SwAvailabilityDetail availabilityDetail = SwAvailabilityDetailServiceService.GetSwAvailabilityDetailById(id);

                if (availabilityDetail != null)
                {
                    return Ok(availabilityDetail);
                }
                else
                {
                    return BadRequest("Support worker availability detail not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
