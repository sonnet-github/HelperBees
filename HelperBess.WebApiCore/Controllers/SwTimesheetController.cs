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
    public class SwTimesheetController : ControllerBase
    {
        private readonly ISwTimesheetService SwTimesheetServiceService;
        public SwTimesheetController(ISwTimesheetService iSwTimesheetService)
        {
            SwTimesheetServiceService = iSwTimesheetService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwTimesheet/GetSwTimesheet")]
        public IActionResult GetSwTimesheet(int? supportWorkerId = null, int? timesheetStatus = null)
        {
            try
            {
                List<SwTimesheet> swTimesheets = SwTimesheetServiceService.GetSwTimesheet(supportWorkerId, timesheetStatus).ToList();

                if (swTimesheets != null && swTimesheets.Any())
                {
                    return Ok(swTimesheets);
                }
                else
                {
                    return BadRequest("No timesheet(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }            
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwTimesheet/AddSwTimesheet")]
        public IActionResult AddSwTimesheet(SwTimesheet SwTimesheet)
        {
            try
            {
                SwTimesheet swTimesheet = SwTimesheetServiceService.AddSwTimesheet(SwTimesheet);

                if (swTimesheet != null)
                {
                    return Ok(swTimesheet);
                }
                else
                {
                    return BadRequest("Failed to add timesheet.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwTimesheet/UpdateSwTimesheet")]
        public IActionResult UpdateSwTimesheet(SwTimesheet SwTimesheet)
        {
            try
            {
                SwTimesheet currentTimeSheet = SwTimesheetServiceService.GetSwTimesheetById(SwTimesheet.TimesheetId);

                if (currentTimeSheet != null)
                {
                    #region Timesheet to update

                    currentTimeSheet.TimesheetId = SwTimesheet.TimesheetId;
                    currentTimeSheet.SupportWorkerId = SwTimesheet.SupportWorkerId;
                    currentTimeSheet.JobId = SwTimesheet.JobId;
                    currentTimeSheet.StartTime = SwTimesheet.StartTime;
                    currentTimeSheet.EndTime = SwTimesheet.EndTime;
                    currentTimeSheet.Rate = SwTimesheet.Rate;
                    currentTimeSheet.ShiftNotes = SwTimesheet.ShiftNotes;
                    currentTimeSheet.Incident = SwTimesheet.Incident;
                    currentTimeSheet.TimesheetStatusId = SwTimesheet.TimesheetStatusId;
                    currentTimeSheet.PaymentReceived = SwTimesheet.PaymentReceived;

                    #endregion

                    SwTimesheet swTimeSheet = SwTimesheetServiceService.UpdateSwTimesheet(currentTimeSheet);

                    if (swTimeSheet != null)
                    {
                        return Ok(swTimeSheet);
                    }
                    else
                    {
                        return BadRequest("Failed to update timesheet.");
                    }
                }
                else
                {
                    return BadRequest("Timesheet not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwTimesheet/DeleteSwTimesheet")]
        public IActionResult DeleteSwTimesheet(int id)
        {
            try
            {
                SwTimesheet currentTimesheet = SwTimesheetServiceService.GetSwTimesheetById(id);

                if (currentTimesheet != null)
                {
                    SwTimesheet swTimesheet = SwTimesheetServiceService.DeleteSwTimesheet(id);

                    return Ok(swTimesheet);
                }
                else
                {
                    return BadRequest("Timesheet not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwTimesheet/GetSwTimesheetById")]
        public IActionResult GetSwTimesheetById(int id)
        {
            try
            {
                SwTimesheet swTimesheet = SwTimesheetServiceService.GetSwTimesheetById(id);

                if (swTimesheet != null)
                {
                    return Ok(swTimesheet);
                }
                else
                {
                    return BadRequest("Timesheet not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
