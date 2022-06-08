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
    public class ScSupportCoordinatorSupportWorkerController : ControllerBase
    {
        private readonly IScSupportCoordinatorSupportWorkerService ScSupportCoordinatorSupportWorkerServiceService;
        public ScSupportCoordinatorSupportWorkerController(IScSupportCoordinatorSupportWorkerService iScSupportCoordinatorSupportWorkerService)
        {
            ScSupportCoordinatorSupportWorkerServiceService = iScSupportCoordinatorSupportWorkerService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ScSupportCoordinatorSupportWorker/GetScSupportCoordinatorSupportWorker")]
        public IActionResult GetScSupportCoordinatorSupportWorker()
        {
            try
            {
                List<ScSupportCoordinatorSupportWorker> supportCoordinatorSupportWorkers = ScSupportCoordinatorSupportWorkerServiceService.GetScSupportCoordinatorSupportWorker().ToList();

                if (supportCoordinatorSupportWorkers != null && supportCoordinatorSupportWorkers.Any())
                {
                    return Ok(supportCoordinatorSupportWorkers);
                }
                else
                {
                    return BadRequest("No support coordinator support worker(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ScSupportCoordinatorSupportWorker/AddScSupportCoordinatorSupportWorker")]
        public IActionResult AddScSupportCoordinatorSupportWorker(ScSupportCoordinatorSupportWorker ScSupportCoordinatorSupportWorker)
        {
            try
            {
                ScSupportCoordinatorSupportWorker supportCoordinatorSupportWorker = ScSupportCoordinatorSupportWorkerServiceService.AddScSupportCoordinatorSupportWorker(ScSupportCoordinatorSupportWorker);

                if (supportCoordinatorSupportWorker != null)
                {
                    return Ok(supportCoordinatorSupportWorker);
                }
                else
                {
                    return BadRequest("Failed to add support coordinator support worker.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ScSupportCoordinatorSupportWorker/UpdateScSupportCoordinatorSupportWorker")]
        public IActionResult UpdateScSupportCoordinatorSupportWorker(ScSupportCoordinatorSupportWorker ScSupportCoordinatorSupportWorker)
        {
            try
            {
                ScSupportCoordinatorSupportWorker currentSupportCoordinatorSupportWorker = ScSupportCoordinatorSupportWorkerServiceService.GetScSupportCoordinatorSupportWorkerById(ScSupportCoordinatorSupportWorker.UpportCoordinatorSupportWorkerId);

                if (currentSupportCoordinatorSupportWorker != null)
                {
                    #region Support Coordinator Suppor tWorker to update

                    currentSupportCoordinatorSupportWorker.UpportCoordinatorSupportWorkerId = ScSupportCoordinatorSupportWorker.UpportCoordinatorSupportWorkerId;
                    currentSupportCoordinatorSupportWorker.SupportCoordinatorId = ScSupportCoordinatorSupportWorker.SupportCoordinatorId;
                    currentSupportCoordinatorSupportWorker.Status = ScSupportCoordinatorSupportWorker.Status;

                    #endregion

                    ScSupportCoordinatorSupportWorker supportCoordinatorSupportWorker = ScSupportCoordinatorSupportWorkerServiceService.UpdateScSupportCoordinatorSupportWorker(currentSupportCoordinatorSupportWorker);

                    if (supportCoordinatorSupportWorker != null)
                    {
                        return Ok(supportCoordinatorSupportWorker);
                    }
                    else
                    {
                        return BadRequest("Failed to update support coordinator support worker.");
                    }
                }
                else
                {
                    return BadRequest("Support coordinator support worker not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ScSupportCoordinatorSupportWorker/DeleteScSupportCoordinatorSupportWorker")]
        public IActionResult DeleteScSupportCoordinatorSupportWorker(int id)
        {
            try
            {
                ScSupportCoordinatorSupportWorker currentSupportCoordinatorSupportWorker = ScSupportCoordinatorSupportWorkerServiceService.GetScSupportCoordinatorSupportWorkerById(id);

                if (currentSupportCoordinatorSupportWorker != null)
                {
                    ScSupportCoordinatorSupportWorker supportCoordinatorSupportWorker = ScSupportCoordinatorSupportWorkerServiceService.DeleteScSupportCoordinatorSupportWorker(id);

                    return Ok(supportCoordinatorSupportWorker);
                }
                else
                {
                    return BadRequest("Support coordinator support worker not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ScSupportCoordinatorSupportWorker/GetScSupportCoordinatorSupportWorkerById")]
        public IActionResult GetScSupportCoordinatorSupportWorkerById(int id)
        {
            try
            {
                ScSupportCoordinatorSupportWorker supportCoordinatorSupportWorker = ScSupportCoordinatorSupportWorkerServiceService.GetScSupportCoordinatorSupportWorkerById(id);

                if (supportCoordinatorSupportWorker != null)
                {
                    return Ok(supportCoordinatorSupportWorker);
                }
                else
                {
                    return BadRequest("Support coordinator support worker not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
