using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HelperBess.WebApiCore.Controllers
{
    ////////////////[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]
    public class ChangeLogController : ControllerBase
    {
        private readonly IChangeLogService ChangeLogServiceService;
        public ChangeLogController(IChangeLogService iChangeLogService)
        {
            ChangeLogServiceService = iChangeLogService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ChangeLog/GetChangeLog")]
        //[Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin": "http://mywebclient.azurewebsites.net", headers: "*", methods: "*")]
        public IActionResult GetChangeLog()
        {
            try
            {
                List<ChangeLog> changeLogs = ChangeLogServiceService.GetChangeLog().ToList();

                if (changeLogs != null && changeLogs.Any())
                {
                    return Ok(changeLogs);
                }
                else
                {
                    return BadRequest("No change log(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ChangeLog/AddChangeLog")]
        public IActionResult AddChangeLog(ChangeLog Changelog)
        {
            try
            {
                ChangeLog changeLog = ChangeLogServiceService.AddChangeLog(Changelog);

                if (changeLog != null)
                {
                    return Ok(changeLog);
                }
                else
                {
                    return BadRequest("Failed to add change log.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ChangeLog/UpdateChangeLog")]
        public IActionResult UpdateChangeLog(ChangeLog changelog)
        {
            try
            {
                ChangeLog currentChangeLog = ChangeLogServiceService.GetChangeLogById(changelog.ChangeLogId);

                if (currentChangeLog != null)
                {
                    #region Change Log to update

                    currentChangeLog.ChangeLogId = changelog.ChangeLogId;
                    currentChangeLog.SupportWorkerId = changelog.SupportWorkerId;
                    currentChangeLog.DateTime = changelog.DateTime;
                    currentChangeLog.TableChanged = changelog.TableChanged;
                    currentChangeLog.FieldChanged = changelog.FieldChanged;
                    currentChangeLog.OldValue = changelog.OldValue;
                    currentChangeLog.NewValue = changelog.NewValue;

                    #endregion

                    ChangeLog updatedChangeLog = ChangeLogServiceService.UpdateChangeLog(currentChangeLog);

                    if (updatedChangeLog != null)
                    {
                        return Ok(updatedChangeLog);
                    }
                    else
                    {
                        return BadRequest("Failed to update change log.");
                    }
                }
                else
                {
                    return BadRequest("Change log not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ChangeLog/DeleteChangeLog")]
        public IActionResult DeleteChangeLog(int id)
        {
            try
            {
                ChangeLog currentChangeLog = ChangeLogServiceService.GetChangeLogById(id);

                if (currentChangeLog != null)
                {
                    ChangeLog changeLog = ChangeLogServiceService.DeleteChangeLog(id);

                    return Ok(changeLog);
                }
                else
                {
                    return BadRequest("Change log not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ChangeLog/GetChangeLogById")]
        public IActionResult GetChangeLogById(int id)
        {
            try
            {
                ChangeLog changeLog = ChangeLogServiceService.GetChangeLogById(id);

                if (changeLog != null)
                {
                    return Ok(changeLog);
                }
                else
                {
                    return BadRequest("Change log not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
