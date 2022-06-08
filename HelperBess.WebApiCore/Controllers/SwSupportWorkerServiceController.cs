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
    public class SwSupportWorkerServiceController : Controller
    {
        private readonly ISwSupportWorkerServiceService SwSupportWorkerServiceServiceService;

        public SwSupportWorkerServiceController(ISwSupportWorkerServiceService iSwSupportWorkerServiceService)
        {
            SwSupportWorkerServiceServiceService = iSwSupportWorkerServiceService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerService/GetSwSupportWorkerService")]
        public IActionResult GetSwSupportWorkerService()
        {
            try
            {
                List<SwSupportWorkerService> swServices = SwSupportWorkerServiceServiceService.GetSwSupportWorkerService().ToList();

                if (swServices != null && swServices.Any())
                {
                    return Ok(swServices);
                }
                else
                {
                    return BadRequest("No support worker service(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerService/AddSwSupportWorkerService")]
        public IActionResult AddSwSupportWorkerService(SwSupportWorkerService SwSupportWorkerService)
        {
            try
            {
                SwSupportWorkerService swService = SwSupportWorkerServiceServiceService.AddSwSupportWorkerService(SwSupportWorkerService);

                if (swService != null)
                {
                    return Ok(swService);
                }
                else
                {
                    return BadRequest("Failed to add support worker service.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerService/UpdateSwSupportWorkerService")]
        public IActionResult UpdateSwSupportWorkerService(SwSupportWorkerService SwSupportWorkerService)
        {
            try
            {
                SwSupportWorkerService swCurrentService = SwSupportWorkerServiceServiceService.GetSwSupportWorkerServiceById(SwSupportWorkerService.SupportWorkerServiceId);

                if (swCurrentService != null)
                {
                    #region Service to update

                    swCurrentService.SupportWorkerServiceId = SwSupportWorkerService.SupportWorkerServiceId;
                    swCurrentService.SupportWorkerId = SwSupportWorkerService.SupportWorkerId;
                    swCurrentService.ServiceId = SwSupportWorkerService.ServiceId;

                    #endregion

                    SwSupportWorkerService swService = SwSupportWorkerServiceServiceService.UpdateSwSupportWorkerService(swCurrentService);

                    if (swService != null)
                    {
                        return Ok(swService);
                    }
                    else
                    {
                        return BadRequest("Failed to update support worker service.");
                    }
                }
                else
                {
                    return BadRequest("Support worker service not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerService/DeleteSwSupportWorkerService")]
        public IActionResult DeleteSwSupportWorkerService(int id)
        {
            try
            {
                SwSupportWorkerService swCurrentService = SwSupportWorkerServiceServiceService.GetSwSupportWorkerServiceById(id);

                if (swCurrentService != null)
                {
                    SwSupportWorkerService swService = SwSupportWorkerServiceServiceService.DeleteSwSupportWorkerService(id);

                    return Ok(swService);
                }
                else
                {
                    return BadRequest("Support worker service not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerService/GetSwSupportWorkerServiceById")]
        public IActionResult GetSwSupportWorkerServiceById(int id)
        {
            try
            {
                SwSupportWorkerService swService = SwSupportWorkerServiceServiceService.GetSwSupportWorkerServiceById(id);

                if (swService != null)
                {
                    return Ok(swService);
                }
                else
                {
                    return BadRequest("Support worker service not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
