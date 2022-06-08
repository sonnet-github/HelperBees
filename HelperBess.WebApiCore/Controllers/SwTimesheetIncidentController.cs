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
    public class SwTimesheetIncidentController : ControllerBase
    {
        private readonly ISwTimesheetIncidentService SwTimesheetIncidentServiceService;
        public SwTimesheetIncidentController(ISwTimesheetIncidentService iSwTimesheetIncidentService)
        {
            SwTimesheetIncidentServiceService = iSwTimesheetIncidentService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwTimesheetIncident/GetSwTimesheetIncident")]
        public IActionResult GetSwTimesheetIncident()
        {
            try
            {
                List<SwTimesheetIncident> swTimesheetIncidents = SwTimesheetIncidentServiceService.GetSwTimesheetIncident().ToList();

                if (swTimesheetIncidents != null && swTimesheetIncidents.Any())
                {
                    return Ok(swTimesheetIncidents);
                }
                else
                {
                    return BadRequest("No timesheet incident(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwTimesheetIncident/AddSwTimesheetIncident")]
        public IActionResult AddSwTimesheetIncident(SwTimesheetIncident SwTimesheetIncident)
        {
            try
            {
                SwTimesheetIncident swTimesheetIncident = SwTimesheetIncidentServiceService.AddSwTimesheetIncident(SwTimesheetIncident);

                if (swTimesheetIncident != null)
                {
                    return Ok(swTimesheetIncident);
                }
                else
                {
                    return BadRequest("Failed to add timesheet incident.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwTimesheetIncident/UpdateSwTimesheetIncident")]
        public IActionResult UpdateSwTimesheetIncident(SwTimesheetIncident SwTimesheetIncident)
        {
            try
            {
                SwTimesheetIncident currentTimesheetIncident = SwTimesheetIncidentServiceService.GetSwTimesheetIncidentById(SwTimesheetIncident.IncidentId);

                if (currentTimesheetIncident != null)
                {
                    #region Timesheet Incident to update

                    currentTimesheetIncident.IncidentId = SwTimesheetIncident.IncidentId;
                    currentTimesheetIncident.TimesheetId = SwTimesheetIncident.TimesheetId;
                    currentTimesheetIncident.IncidentDetails = SwTimesheetIncident.IncidentDetails;

                    #endregion

                    SwTimesheetIncident swTimesheetIncident = SwTimesheetIncidentServiceService.UpdateSwTimesheetIncident(currentTimesheetIncident);

                    if (swTimesheetIncident != null)
                    {
                        return Ok(swTimesheetIncident);
                    }
                    else
                    {
                        return BadRequest("Failed to update timesheet incident.");
                    }
                }
                else
                {
                    return BadRequest("Timesheet incident not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwTimesheetIncident/DeleteSwTimesheetIncident")]
        public IActionResult DeleteSwTimesheetIncident(int id)
        {
            try
            {
                SwTimesheetIncident currentTimesheetIncident = SwTimesheetIncidentServiceService.GetSwTimesheetIncidentById(id);

                if (currentTimesheetIncident != null)
                {
                    SwTimesheetIncident swTimesheetIncident = SwTimesheetIncidentServiceService.DeleteSwTimesheetIncident(id);

                    return Ok(swTimesheetIncident);
                }
                else
                {
                    return BadRequest("Timesheet incident not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwTimesheetIncident/GetSwTimesheetIncidentById")]
        public IActionResult GetSwTimesheetIncidentById(int id)
        {
            try
            {
                SwTimesheetIncident swTimesheetIncident = SwTimesheetIncidentServiceService.GetSwTimesheetIncidentById(id);

                if (swTimesheetIncident != null)
                {
                    return Ok(swTimesheetIncident);
                }
                else
                {
                    return BadRequest("Timesheet incident not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
