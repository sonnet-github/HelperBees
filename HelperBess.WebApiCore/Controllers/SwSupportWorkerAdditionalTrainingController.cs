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
    public class SwSupportWorkerAdditionalTrainingController : ControllerBase
    {
        private readonly ISwSupportWorkerAdditionalTrainingService SwSupportWorkerAdditionalTrainingServiceService;
        public SwSupportWorkerAdditionalTrainingController(ISwSupportWorkerAdditionalTrainingService iSwSupportWorkerAdditionalTrainingService)
        {
            SwSupportWorkerAdditionalTrainingServiceService = iSwSupportWorkerAdditionalTrainingService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerAdditionalTraining/GetSwSupportWorkerAdditionalTraining")]
        public IActionResult GetSwSupportWorkerAdditionalTraining()
        {
            try
            {
                List<SwSupportWorkerAdditionalTraining> swTrainings = SwSupportWorkerAdditionalTrainingServiceService.GetSwSupportWorkerAdditionalTraining().ToList();

                if (swTrainings != null && swTrainings.Any())
                {
                    return Ok(swTrainings);
                }
                else
                {
                    return BadRequest("No support worker addition training(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerAdditionalTraining/AddSwSupportWorkerAdditionalTraining")]
        public IActionResult AddSwSupportWorkerAdditionalTraining(SwSupportWorkerAdditionalTraining SwSupportWorkerAdditionalTraining)
        {
            try
            {
                SwSupportWorkerAdditionalTraining swTraining = SwSupportWorkerAdditionalTrainingServiceService.AddSwSupportWorkerAdditionalTraining(SwSupportWorkerAdditionalTraining);

                if (swTraining != null)
                {
                    return Ok(swTraining);
                }
                else
                {
                    return BadRequest("Failed to add support worker additional training.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerAdditionalTraining/UpdateSwSupportWorkerAdditionalTraining")]
        public IActionResult UpdateSwSupportWorkerAdditionalTraining(SwSupportWorkerAdditionalTraining SwSupportWorkerAdditionalTraining)
        {
            try
            {
                SwSupportWorkerAdditionalTraining swCurrentTraining = SwSupportWorkerAdditionalTrainingServiceService.GetSwSupportWorkerAdditionalTrainingById(SwSupportWorkerAdditionalTraining.SupportWorkerAdditionalTrainingId);

                if (swCurrentTraining != null)
                {
                    swCurrentTraining.SupportWorkerAdditionalTrainingId = SwSupportWorkerAdditionalTraining.SupportWorkerAdditionalTrainingId;
                    swCurrentTraining.SupportWorkerId = SwSupportWorkerAdditionalTraining.SupportWorkerId;
                    swCurrentTraining.Cprcertificate = SwSupportWorkerAdditionalTraining.Cprcertificate;
                    swCurrentTraining.Cprupload = SwSupportWorkerAdditionalTraining.Cprupload;
                    swCurrentTraining.CpracquiredDate = SwSupportWorkerAdditionalTraining.CpracquiredDate;
                    swCurrentTraining.CprexpiryDate = SwSupportWorkerAdditionalTraining.CprexpiryDate;
                    swCurrentTraining.FirstAidCertificate = SwSupportWorkerAdditionalTraining.FirstAidCertificate;
                    swCurrentTraining.FirstAidUpload = SwSupportWorkerAdditionalTraining.FirstAidUpload;
                    swCurrentTraining.FirstAidAcquiredDate = SwSupportWorkerAdditionalTraining.FirstAidAcquiredDate;
                    swCurrentTraining.FirstAidExpiryDate = SwSupportWorkerAdditionalTraining.FirstAidExpiryDate;
                    swCurrentTraining.Ndiswomcertificate = SwSupportWorkerAdditionalTraining.Ndiswomcertificate;
                    swCurrentTraining.Ndiswomupload = SwSupportWorkerAdditionalTraining.Ndiswomupload;
                    swCurrentTraining.NdiswomacquiredDate = SwSupportWorkerAdditionalTraining.NdiswomacquiredDate;
                    swCurrentTraining.NdiswomexpiryDate = SwSupportWorkerAdditionalTraining.NdiswomexpiryDate;
                    swCurrentTraining.Covidicc = SwSupportWorkerAdditionalTraining.Covidicc;
                    swCurrentTraining.Covidiccupload = SwSupportWorkerAdditionalTraining.Covidiccupload;
                    swCurrentTraining.CovidiccacquiredDate = SwSupportWorkerAdditionalTraining.CovidiccacquiredDate;
                    swCurrentTraining.CovidiccexpiryDate = SwSupportWorkerAdditionalTraining.CovidiccexpiryDate;

                    SwSupportWorkerAdditionalTraining swTraining = SwSupportWorkerAdditionalTrainingServiceService.UpdateSwSupportWorkerAdditionalTraining(swCurrentTraining);

                    if (swTraining != null)
                    {
                        return Ok(swTraining);
                    }
                    else
                    {
                        return BadRequest("Failed to update support worker additional training.");
                    }
                }
                else
                {
                    return BadRequest("Support worker additional training not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerAdditionalTraining/DeleteSwSupportWorkerAdditionalTraining")]
        public IActionResult DeleteSwSupportWorkerAdditionalTraining(int id)
        {
            try
            {
                SwSupportWorkerAdditionalTraining swCurrentTraining = SwSupportWorkerAdditionalTrainingServiceService.GetSwSupportWorkerAdditionalTrainingById(id);

                if (swCurrentTraining != null)
                {
                    SwSupportWorkerAdditionalTraining swTraining = SwSupportWorkerAdditionalTrainingServiceService.DeleteSwSupportWorkerAdditionalTraining(id);

                    return Ok(swTraining);
                }
                else
                {
                    return BadRequest("Support worker additional training not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerAdditionalTraining/GetSwSupportWorkerAdditionalTrainingById")]
        public IActionResult GetSwSupportWorkerAdditionalTrainingById(int id)
        {
            try
            {
                SwSupportWorkerAdditionalTraining swTraining = SwSupportWorkerAdditionalTrainingServiceService.GetSwSupportWorkerAdditionalTrainingById(id);

                if (swTraining != null)
                {
                    return Ok(swTraining);
                }
                else
                {
                    return BadRequest("Support worker additional training not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
