using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]
    public class SwSupportWorkerController : ControllerBase
    {
        private readonly ISwSupportWorkerService swSupportWorkerService;
        public SwSupportWorkerController(ISwSupportWorkerService swSupportWorker)
        {
            swSupportWorkerService = swSupportWorker;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorker/GetSwSupportWorker")]
        public IActionResult GetSwSupportWorkerByLogin(string email, string password)
        {
            try
            {
                SwSupportWorker worker = swSupportWorkerService.GetSwSupportWorkerByLogin(email, password);

                if (worker != null)
                {
                    return Ok(worker);
                }
                else
                {
                    return BadRequest("Support worker not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorker/AddSwSupportWorker")]
        public IActionResult AddSwSupportWorker(SwSupportWorker swSupportWorker)
        {
            try
            {
                SwSupportWorker currentWorker = swSupportWorkerService.GetSwSupportWorkerByEmail(swSupportWorker.EmailAddress);

                if (currentWorker == null)
                {
                    SwSupportWorker worker = swSupportWorkerService.AddSwSupportWorker(swSupportWorker);

                    if (worker != null)
                    {
                        return Ok(worker);
                    }
                    else
                    {
                        return BadRequest("Failed to add Support worker.");
                    }
                }
                else
                {
                    return BadRequest($"E-mail address {swSupportWorker.EmailAddress} is already used by another account holder.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorker/EditSwSupportWorker")]
        public IActionResult EditEmployee(SwSupportWorker swSupportWorker)
        {
            try
            {
                SwSupportWorker currentWorker = swSupportWorkerService.GetSwSupportWorkerById(swSupportWorker.SupportWorkerId);

                if (currentWorker != null)
                {
                    currentWorker.SupportWorkerId = swSupportWorker.SupportWorkerId;
                    currentWorker.EmailAddress = swSupportWorker.EmailAddress;
                    currentWorker.Password = swSupportWorker.Password;
                    currentWorker.FailedLoginCount = swSupportWorker.FailedLoginCount;
                    currentWorker.DateCreated = swSupportWorker.DateCreated;
                    currentWorker.StatusId = swSupportWorker.StatusId;
                    currentWorker.Locked = swSupportWorker.Locked;
                    currentWorker.Active = swSupportWorker.Active;

                    SwSupportWorker worker = swSupportWorkerService.UpdateSwSupportWorker(currentWorker);

                    if (worker != null)
                    {
                        return Ok(worker);
                    }
                    else
                    {
                        return BadRequest("Failed to update Support worker.");
                    }
                }
                else
                {
                    return BadRequest("Support worker not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorker/DeleteSwSupportWorker")]
        public IActionResult DeleteSwSupportWorker(int id)
        {
            try
            {
                SwSupportWorker currentWorker = swSupportWorkerService.GetSwSupportWorkerById(id);

                if (currentWorker != null)
                {
                    SwSupportWorker worker = swSupportWorkerService.DeleteSwSupportWorker(id);

                    return Ok(worker);
                }
                else
                {
                    return BadRequest("Support worker not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorker/GetSwSupportWorkerById")]
        public IActionResult GetSwSupportWorkerById(int id)
        {
            try
            {
                SwSupportWorker worker = swSupportWorkerService.GetSwSupportWorkerById(id);

                if (worker != null)
                {
                    return Ok(worker);
                }
                else
                {
                    return BadRequest("Support worker not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //[HttpGet]
        //[Route("[action]")]
        //[Route("api/SwSupportWorker/GetSwSupportWorkerByStatus")]
        //public IEnumerable<SwSupportWorker> GetSwSupportWorkerByStatus(string status)
        //{
        //    return swSupportWorkerService.GetSwSupportWorkerByStatus(status);
        //}

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorker/GetSwSupportWorkerActive")]
        public IEnumerable<SwSupportWorker> GetSwSupportWorkerActive(bool Active)
        {
            return swSupportWorkerService.GetSwSupportWorkerActive(Active);
        }

    }
}
