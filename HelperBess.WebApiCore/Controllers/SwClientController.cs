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
    public class SwClientController : ControllerBase
    {
        private readonly ISwClientService SwClientServiceService;
        public SwClientController(ISwClientService iSwClientService)
        {
            SwClientServiceService = iSwClientService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwClient/GetSwClient")]
        public IActionResult GetSwClient()
        {
            try
            {
                List<SwClient> clients = SwClientServiceService.GetSwClient().ToList();

                if (clients != null && clients.Any())
                {
                    return Ok(clients);
                }
                else
                {
                    return BadRequest("No client(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        [Route("[action]")]
        [Route("api/SwClient/AddSwClient")]
        public IActionResult AddSwClient(SwClient SwClient)
        {
            try
            {
                SwClient client = SwClientServiceService.AddSwClient(SwClient);

                if (client != null)
                {
                    return Ok(client);
                }
                else
                {
                    return BadRequest("Failed to add client.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwClient/UpdateSwClient")]
        public IActionResult UpdateSwClient(SwClient SwClient)
        {
            try
            {
                SwClient currentClient = SwClientServiceService.GetSwClientById(SwClient.ClientId);

                if (currentClient != null)
                {
                    #region Client to update

                    currentClient.ClientId = SwClient.ClientId;
                    currentClient.SupportWorkerId = SwClient.SupportWorkerId;
                    currentClient.Status = SwClient.Status;
                    currentClient.DateAdded = SwClient.DateAdded;
                    currentClient.Notes = SwClient.Notes;

                    #endregion

                    SwClient client = SwClientServiceService.UpdateSwClient(currentClient);

                    if (client != null)
                    {
                        return Ok(client);
                    }
                    else
                    {
                        return BadRequest("Failed to update client.");
                    }
                }
                else
                {
                    return BadRequest("Client not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwClient/DeleteSwClient")]
        public IActionResult DeleteSwClient(int id)
        {
            try
            {
                SwClient currentClient = SwClientServiceService.GetSwClientById(id);

                if (currentClient != null)
                {
                    SwClient client = SwClientServiceService.DeleteSwClient(id);

                    return Ok(client);
                }
                else
                {
                    return BadRequest("Client not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwClient/GetSwClientById")]
        public IActionResult GetSwClientById(int id)
        {
            try
            {
                SwClient client = SwClientServiceService.GetSwClientById(id);

                if (client != null)
                {
                    return Ok(client);
                }
                else
                {
                    return BadRequest("Client not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwClient/GetSwClientBySupportWorkerId")]
        public IActionResult GetSwClientBySupportWorkerId(int supportWorkerId)
        {
            try
            {
                List<SwClient> clients = SwClientServiceService.GetSwClientBySupportWorkerId(supportWorkerId).ToList();

                if (clients != null)
                {
                    return Ok(clients);
                }
                else
                {
                    return BadRequest("No client(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwClient/GetSwClientByParticipantId")]
        public IActionResult GetSwClientByParticipantId(int ParticpantId)
        {
            try
            {
                List<SwClient> clients = SwClientServiceService.GetSwClientByParticipantId(ParticpantId).ToList();

                if (clients != null)
                {
                    return Ok(clients);
                }
                else
                {
                    return BadRequest("No client(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }




    }
}
