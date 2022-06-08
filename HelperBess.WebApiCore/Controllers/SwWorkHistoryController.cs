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
    public class SwWorkHistoryController : ControllerBase
    {
        private readonly ISwWorkHistoryService SwWorkHistoryServiceService;
        public SwWorkHistoryController(ISwWorkHistoryService iSwWorkHistoryService)
        {
            SwWorkHistoryServiceService = iSwWorkHistoryService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwWorkHistory/GetSwWorkHistory")]
        public IActionResult GetSwWorkHistory()
        {
            try
            {
                List<SwWorkHistory> swWorkHistories = SwWorkHistoryServiceService.GetSwWorkHistory().ToList();

                if (swWorkHistories != null && swWorkHistories.Any())
                {
                    return Ok(swWorkHistories);
                }
                else
                {
                    return BadRequest("No work history available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwWorkHistory/AddSwWorkHistory")]
        public IActionResult AddSwWorkHistory(SwWorkHistory SwWorkHistory)
        {
            try
            {
                SwWorkHistory swWorkHistory = SwWorkHistoryServiceService.AddSwWorkHistory(SwWorkHistory);

                if (swWorkHistory != null)
                {
                    return Ok(swWorkHistory);
                }
                else
                {
                    return BadRequest("Failed to add work history.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwWorkHistory/UpdateSwWorkHistory")]
        public IActionResult UpdateSwWorkHistory(SwWorkHistory SwWorkHistory)
        {
            try
            {
                SwWorkHistory currentWorkHistory = SwWorkHistoryServiceService.GetSwWorkHistoryById(SwWorkHistory.WorkHistoryId);

                if (currentWorkHistory != null)
                {
                    #region Work History to update

                    currentWorkHistory.WorkHistoryId = SwWorkHistory.WorkHistoryId;
                    currentWorkHistory.SupportWorkerId = SwWorkHistory.SupportWorkerId;
                    currentWorkHistory.JobTitle = SwWorkHistory.JobTitle;

                    #endregion

                    SwWorkHistory swWorkHistory = SwWorkHistoryServiceService.UpdateSwWorkHistory(currentWorkHistory);

                    if (swWorkHistory != null)
                    {
                        return Ok(swWorkHistory);
                    }
                    else
                    {
                        return BadRequest("Failed to update work history.");
                    }
                }
                else
                {
                    return BadRequest("Work history not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwWorkHistory/DeleteSwWorkHistory")]
        public IActionResult DeleteSwWorkHistory(int id)
        {
            try
            {
                SwWorkHistory currentWorkHistory = SwWorkHistoryServiceService.GetSwWorkHistoryById(id);

                if (currentWorkHistory != null)
                {
                    SwWorkHistory swWorkHistory = SwWorkHistoryServiceService.DeleteSwWorkHistory(id);

                    return Ok(swWorkHistory);
                }
                else
                {
                    return BadRequest("Work history not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwWorkHistory/GetSwWorkHistoryById")]
        public IActionResult GetSwWorkHistoryById(int id)
        {
            try
            {
                SwWorkHistory swWorkHistory = SwWorkHistoryServiceService.GetSwWorkHistoryById(id);

                if (swWorkHistory != null)
                {
                    return Ok(swWorkHistory);
                }
                else
                {
                    return BadRequest("Work history not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
