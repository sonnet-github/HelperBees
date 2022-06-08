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
    public class SwTimesheetStatusController : ControllerBase
    {
        private readonly ISwTimesheetStatusService SwTimesheetStatusServiceService;
        public SwTimesheetStatusController(ISwTimesheetStatusService iSwTimesheetStatusService)
        {
            SwTimesheetStatusServiceService = iSwTimesheetStatusService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwTimesheetStatus/GetSwTimesheetStatus")]
        public IActionResult GetSwTimesheetStatus()
        {
            try
            {
                List<SwTimesheetStatus> swTimesheetStatuses = SwTimesheetStatusServiceService.GetSwTimesheetStatus().ToList();

                if (swTimesheetStatuses != null && swTimesheetStatuses.Any())
                {
                    return Ok(swTimesheetStatuses);
                }
                else
                {
                    return BadRequest("No timesheet status available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwTimesheetStatus/AddSwTimesheetStatus")]
        public IActionResult AddSwTimesheetStatus(SwTimesheetStatus SwTimesheetStatus)
        {
            try
            {
                SwTimesheetStatus swTimesheetStatus = SwTimesheetStatusServiceService.AddSwTimesheetStatus(SwTimesheetStatus);

                if (swTimesheetStatus != null)
                {
                    return Ok(swTimesheetStatus);
                }
                else
                {
                    return BadRequest("Failed to add timesheet status.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwTimesheetStatus/UpdateSwTimesheetStatus")]
        public IActionResult UpdateSwTimesheetStatus(SwTimesheetStatus SwTimesheetStatus)
        {
            try
            {
                SwTimesheetStatus currentTimesheetStatus = SwTimesheetStatusServiceService.GetSwTimesheetStatusById(SwTimesheetStatus.TimesheetStatusId);

                if (currentTimesheetStatus != null)
                {
                    #region Timesheet Status to update

                    currentTimesheetStatus.TimesheetStatusId = SwTimesheetStatus.TimesheetStatusId;
                    currentTimesheetStatus.Status = SwTimesheetStatus.Status;
                    
                    #endregion

                    SwTimesheetStatus swTimesheetStatus = SwTimesheetStatusServiceService.UpdateSwTimesheetStatus(currentTimesheetStatus);

                    if (swTimesheetStatus != null)
                    {
                        return Ok(swTimesheetStatus);
                    }
                    else
                    {
                        return BadRequest("Failed to update timesheet status.");
                    }
                }
                else
                {
                    return BadRequest("Timesheet status not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwTimesheetStatus/DeleteSwTimesheetStatus")]
        public IActionResult DeleteSwTimesheetStatus(int id)
        {
            try
            {
                SwTimesheetStatus currentTimesheetStatus = SwTimesheetStatusServiceService.GetSwTimesheetStatusById(id);

                if (currentTimesheetStatus != null)
                {
                    SwTimesheetStatus swTimesheetStatus = SwTimesheetStatusServiceService.DeleteSwTimesheetStatus(id);

                    return Ok(swTimesheetStatus);
                }
                else
                {
                    return BadRequest("Timesheet status not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwTimesheetStatus/GetSwTimesheetStatusById")]
        public IActionResult GetSwTimesheetStatusById(int id)
        {
            try
            {
                SwTimesheetStatus swTimesheetStatus = SwTimesheetStatusServiceService.GetSwTimesheetStatusById(id);

                if (swTimesheetStatus != null)
                {
                    return Ok(swTimesheetStatus);
                }
                else
                {
                    return BadRequest("Timesheet status not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
