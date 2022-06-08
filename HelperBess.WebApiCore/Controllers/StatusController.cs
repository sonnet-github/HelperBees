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
    public class StatusController : ControllerBase
    {
        private readonly IStatusService StatusServiceService;
        public StatusController(IStatusService iStatusService)
        {
            StatusServiceService = iStatusService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Status/GetStatus")]
        public IActionResult GetStatus()
        {
            try
            {
                List<Status> statuses = StatusServiceService.GetStatus().ToList();

                if (statuses != null && statuses.Any())
                {
                    return Ok(statuses);
                }
                else
                {
                    return BadRequest("No Status(es) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Status/AddStatus")]
        public IActionResult AddStatus(Status Status)
        {
            try
            {
                Status status = StatusServiceService.AddStatus(Status);

                if (status != null)
                {
                    return Ok(status);
                }
                else
                {
                    return BadRequest("Failed to add status.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/Status/UpdateStatus")]
        public IActionResult UpdateStatus(Status Status)
        {
            try
            {
                Status currentStatus = StatusServiceService.GetStatusById(Status.StatusId);

                if (currentStatus != null)
                {
                    #region Status to update

                    currentStatus.StatusId = Status.StatusId;
                    currentStatus.Status1 = Status.Status1;

                    #endregion

                    Status status = StatusServiceService.UpdateStatus(currentStatus);

                    if (status != null)
                    {
                        return Ok(status);
                    }
                    else
                    {
                        return BadRequest("Failed to update status.");
                    }
                }
                else
                {
                    return BadRequest("Status not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Status/DeleteStatus")]
        public IActionResult DeleteStatus(int id)
        {
            try
            {
                Status currentStatus = StatusServiceService.GetStatusById(id);

                if (currentStatus != null)
                {
                    Status status = StatusServiceService.DeleteStatus(id);

                    return Ok(status);
                }
                else
                {
                    return BadRequest("Status not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Status/GetStatusById")]
        public IActionResult GetStatusById(int id)
        {
            try
            {
                Status status = StatusServiceService.GetStatusById(id);

                if (status != null)
                {
                    return Ok(status);
                }
                else
                {
                    return BadRequest("Status not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
