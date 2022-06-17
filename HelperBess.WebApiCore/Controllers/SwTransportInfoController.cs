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
    public class SwTransportInfoController : ControllerBase
    {
        private readonly ISwTransportInfoService SwTransportInfoServiceService;
        public SwTransportInfoController(ISwTransportInfoService iSwTransportInfoService)
        {
            SwTransportInfoServiceService = iSwTransportInfoService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwTransportInfo/GetSwTransportInfo")]
        public IActionResult GetSwTransportInfo()
        {
            try
            {
                List<SwTransportInfo> swTransportInfos = SwTransportInfoServiceService.GetSwTransportInfo().ToList();

                if (swTransportInfos != null && swTransportInfos.Any())
                {
                    return Ok(swTransportInfos);
                }
                else
                {
                    return BadRequest("No transport info(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwTransportInfo/AddSwTransportInfo")]
        public IActionResult AddSwTransportInfo(SwTransportInfo SwTransportInfo)
        {
            try
            {
                SwTransportInfo swTransportInfo = SwTransportInfoServiceService.AddSwTransportInfo(SwTransportInfo);

                if (swTransportInfo != null)
                {
                    return Ok(swTransportInfo);
                }
                else
                {
                    return BadRequest("Failed to add transport info.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwTransportInfo/UpdateSwTransportInfo")]
        public IActionResult UpdateSwTransportInfo(SwTransportInfo SwTransportInfo)
        {
            try
            {
                SwTransportInfo currentTransportInfo = SwTransportInfoServiceService.GetSwTransportInfoById(SwTransportInfo.TransportInfoId);

                if (currentTransportInfo != null)
                {
                    #region Transport Info to update

                    currentTransportInfo.TransportInfoId = SwTransportInfo.TransportInfoId;
                    currentTransportInfo.SupportWorkerId = SwTransportInfo.SupportWorkerId;
                    currentTransportInfo.Dlnumber = SwTransportInfo.Dlnumber;
                    currentTransportInfo.Dlstate = SwTransportInfo.Dlstate;
                    currentTransportInfo.DlexpiryDate = SwTransportInfo.DlexpiryDate;
                    currentTransportInfo.Dlupload = SwTransportInfo.Dlupload;
                    currentTransportInfo.Mvtype = SwTransportInfo.Mvtype;
                    currentTransportInfo.MvlicencePlate = SwTransportInfo.MvlicencePlate;
                    currentTransportInfo.MvregistrationExpiry = SwTransportInfo.MvregistrationExpiry;
                    currentTransportInfo.MvregistrationUpload = SwTransportInfo.MvregistrationUpload;
                    currentTransportInfo.MvinsuranceType = SwTransportInfo.MvinsuranceType;

                    #endregion

                    SwTransportInfo swTransportInfo = SwTransportInfoServiceService.UpdateSwTransportInfo(currentTransportInfo);

                    if (swTransportInfo != null)
                    {
                        return Ok(swTransportInfo);
                    }
                    else
                    {
                        return BadRequest("Failed to update transport info.");
                    }
                }
                else
                {
                    return BadRequest("Transport info not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwTransportInfo/DeleteSwTransportInfo")]
        public IActionResult DeleteSwTransportInfo(int id)
        {
            try
            {
                SwTransportInfo currentTransportInfo = SwTransportInfoServiceService.GetSwTransportInfoById(id);

                if (currentTransportInfo != null)
                {
                    SwTransportInfo swTransportInfo = SwTransportInfoServiceService.DeleteSwTransportInfo(id);

                    return Ok(swTransportInfo);
                }
                else
                {
                    return BadRequest("Transport info not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwTransportInfo/GetSwTransportInfoById")]
        public IActionResult GetSwTransportInfoById(int id)
        {
            try
            {
                SwTransportInfo swTransportInfo = SwTransportInfoServiceService.GetSwTransportInfoById(id);

                if (swTransportInfo != null)
                {
                    return Ok(swTransportInfo);
                }
                else
                {
                    return BadRequest("Transport info not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwTransportInfo/GetSwTransportInfoBySWId")]
        public IActionResult GetSwTransportInfoBySWId(int swid)
        {
            try
            {
                List<SwTransportInfo> swTransportInfos = SwTransportInfoServiceService.GetSwTransportInfoBySWId(swid).ToList();

                if (swTransportInfos != null && swTransportInfos.Any())
                {
                    return Ok(swTransportInfos);
                }
                else
                {
                    return BadRequest("No transport info(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
