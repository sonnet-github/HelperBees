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
    public class SwAvailabilityController : ControllerBase
    {
        private readonly ISwAvailabilityService SwAvailabilityServiceService;
        public SwAvailabilityController(ISwAvailabilityService iSwAvailabilityService)
        {
            SwAvailabilityServiceService = iSwAvailabilityService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwAvailability/GetSwAvailability")]
        public IActionResult GetSwAvailability()
        {
            try
            {
                List<SwAvailability> availabilities = SwAvailabilityServiceService.GetSwAvailability().ToList();

                if (availabilities != null && availabilities.Any())
                {
                    return Ok(availabilities);
                }
                else
                {
                    return BadRequest("No support worker availability available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwAvailability/AddSwAvailability")]
        public IActionResult AddSwAvailability(SwAvailability SwAvailability)
        {
            try
            {
                SwAvailability availability = SwAvailabilityServiceService.AddSwAvailability(SwAvailability);

                if (availability != null)
                {
                    return Ok(availability);
                }
                else
                {
                    return BadRequest("Failed to add support worker availability.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwAvailability/UpdateSwAvailability")]
        public IActionResult UpdateSwAvailability(SwAvailability SwAvailability)
        {
            try
            {
                SwAvailability currentAvailability = SwAvailabilityServiceService.GetSwAvailabilityById(SwAvailability.AvailabilityId);

                if (currentAvailability != null)
                {
                    #region Availability to update

                    currentAvailability.AvailabilityId = SwAvailability.AvailabilityId;
                    currentAvailability.SupportWorkerId = SwAvailability.SupportWorkerId;
                    currentAvailability.AvailabilityId = SwAvailability.AvailabilityId;
                    currentAvailability.MeetForFree = SwAvailability.MeetForFree;
                    currentAvailability.BasePostcode = SwAvailability.BasePostcode;
                    currentAvailability.DistanceWillingToTravel = SwAvailability.DistanceWillingToTravel;
                    currentAvailability.HoursToTravelFurther = SwAvailability.HoursToTravelFurther;
                    currentAvailability.WeekdayRateEarly = SwAvailability.WeekdayRateEarly;
                    currentAvailability.WeekdayRateLate = SwAvailability.WeekdayRateLate;
                    currentAvailability.SaturdayRate = SwAvailability.SaturdayRate;
                    currentAvailability.SundayRate = SwAvailability.SundayRate;
                    currentAvailability.Phrate = SwAvailability.Phrate;
                    currentAvailability.Weekday12HrRate = SwAvailability.Weekday12HrRate;
                    currentAvailability.Weekday24HrRate = SwAvailability.Weekday24HrRate;
                    currentAvailability.RatesNegotiable = SwAvailability.RatesNegotiable;

                    #endregion

                    SwAvailability availability = SwAvailabilityServiceService.UpdateSwAvailability(currentAvailability);

                    if (availability != null)
                    {
                        return Ok(availability);
                    }
                    else
                    {
                        return BadRequest("Failed to update support worker availability.");
                    }
                }
                else
                {
                    return BadRequest("Support worker availability not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwAvailability/DeleteSwAvailability")]
        public IActionResult DeleteSwAvailability(int id)
        {
            try
            {
                SwAvailability currentAvailability = SwAvailabilityServiceService.GetSwAvailabilityById(id);

                if (currentAvailability != null)
                {
                    SwAvailability availability = SwAvailabilityServiceService.DeleteSwAvailability(id);

                    return Ok(availability);
                }
                else
                {
                    return BadRequest("Support worker availability not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwAvailability/GetSwAvailabilityById")]
        public IActionResult GetSwAvailabilityById(int id)
        {
            try
            {
                SwAvailability availability = SwAvailabilityServiceService.GetSwAvailabilityById(id);

                if (availability != null)
                {
                    return Ok(availability);
                }
                else
                {
                    return BadRequest("Support worker availability not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
