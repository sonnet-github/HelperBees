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
    public class ClloginAuditController : ControllerBase
    {
        private readonly IClloginAuditService ClloginAuditServiceService;
        public ClloginAuditController(IClloginAuditService iClloginAuditService)
        {
            ClloginAuditServiceService = iClloginAuditService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClloginAudit/GetClloginAudit")]
        public IActionResult GetClloginAudit()
        {
            try
            {
                List<ClloginAudit> loginAudits = ClloginAuditServiceService.GetClloginAudit().ToList();

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
        [Route("api/ClloginAudit/AddClloginAudit")]
        public IActionResult AddClloginAudit(ClloginAudit ClloginAudit)
        {
            try
            {
                ClloginAudit loginAudit = ClloginAuditServiceService.AddClloginAudit(ClloginAudit);

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
        [Route("api/ClloginAudit/UpdateClloginAudit")]
        public IActionResult UpdateClloginAudit(ClloginAudit ClloginAudit)
        {
            try
            {
                ClloginAudit currentLoginAudit = ClloginAuditServiceService.GetClloginAuditById(ClloginAudit.ClloginAuditId);

                if (currentLoginAudit != null)
                {
                    #region Login Audit to update

                    currentLoginAudit.ClloginAuditId = ClloginAudit.ClloginAuditId;
                    currentLoginAudit.ClientId = ClloginAudit.ClientId;
                    currentLoginAudit.DateTime = ClloginAudit.DateTime;
                    currentLoginAudit.LoginSuccess = ClloginAudit.LoginSuccess;

                    #endregion

                    ClloginAudit loginAudit = ClloginAuditServiceService.UpdateClloginAudit(currentLoginAudit);

                    if (loginAudit != null)
                    {
                        return Ok(loginAudit);
                    }
                    else
                    {
                        return BadRequest("Failed to update login Audit.");
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
        [Route("api/ClloginAudit/DeleteClloginAudit")]
        public IActionResult DeleteClloginAudit(int id)
        {
            try
            {
                ClloginAudit currentLoginAudit = ClloginAuditServiceService.GetClloginAuditById(id);

                if (currentLoginAudit != null)
                {
                    ClloginAudit loginAudit = ClloginAuditServiceService.DeleteClloginAudit(id);

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
        [Route("api/ClloginAudit/GetClloginAuditById")]
        public IActionResult GetClloginAuditById(int id)
        {
            try
            {
                ClloginAudit loginAudit = ClloginAuditServiceService.GetClloginAuditById(id);

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
