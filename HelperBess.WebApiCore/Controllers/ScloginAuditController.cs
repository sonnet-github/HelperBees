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
    public class ScloginAuditController : ControllerBase
    {
        private readonly IScloginAuditService ScloginAuditServiceService;
        public ScloginAuditController(IScloginAuditService iScloginAuditService)
        {
            ScloginAuditServiceService = iScloginAuditService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ScloginAudit/GetScloginAudit")]
        public IActionResult GetScloginAudit()
        {
            try
            {
                List<ScloginAudit> loginAudits = ScloginAuditServiceService.GetScloginAudit().ToList();

                if (loginAudits != null && loginAudits.Any())
                {
                    return Ok(loginAudits);
                }
                else
                {
                    return BadRequest("No login audit(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ScloginAudit/AddScloginAudit")]
        public IActionResult AddScloginAudit(ScloginAudit ScloginAudit)
        {
            try
            {
                ScloginAudit loginAudit = ScloginAuditServiceService.AddScloginAudit(ScloginAudit);

                if (loginAudit != null)
                {
                    return Ok(loginAudit);
                }
                else
                {
                    return BadRequest("Failed to add login audit.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ScloginAudit/UpdateScloginAudit")]
        public IActionResult UpdateScloginAudit(ScloginAudit ScloginAudit)
        {
            try
            {
                ScloginAudit currentLoginAudit = ScloginAuditServiceService.GetScloginAuditById(ScloginAudit.ScloginAuditId);

                if (currentLoginAudit != null)
                {
                    #region Login Audit to update

                    currentLoginAudit.ScloginAuditId = ScloginAudit.ScloginAuditId;
                    currentLoginAudit.SupportCoordinatorId = ScloginAudit.SupportCoordinatorId;
                    currentLoginAudit.DateTime = ScloginAudit.DateTime;
                    currentLoginAudit.LoginSuccess = ScloginAudit.LoginSuccess;

                    #endregion

                    ScloginAudit loginAudit = ScloginAuditServiceService.UpdateScloginAudit(currentLoginAudit);

                    if (loginAudit != null)
                    {
                        return Ok(loginAudit);
                    }
                    else
                    {
                        return BadRequest("Failed to update login audit.");
                    }
                }
                else
                {
                    return BadRequest("Login audit not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ScloginAudit/DeleteScloginAudit")]
        public IActionResult DeleteScloginAudit(int id)
        {
            try
            {
                ScloginAudit currentLoginAudit = ScloginAuditServiceService.GetScloginAuditById(id);

                if (currentLoginAudit != null)
                {
                    ScloginAudit loginAudit = ScloginAuditServiceService.DeleteScloginAudit(id);

                    return Ok(loginAudit);
                }
                else
                {
                    return BadRequest("Login audit not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ScloginAudit/GetScloginAuditById")]
        public IActionResult GetScloginAuditById(int id)
        {
            try
            {
                ScloginAudit loginAudit = ScloginAuditServiceService.GetScloginAuditById(id);

                if (loginAudit != null)
                {
                    return Ok(loginAudit);
                }
                else
                {
                    return BadRequest("Login audit not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
