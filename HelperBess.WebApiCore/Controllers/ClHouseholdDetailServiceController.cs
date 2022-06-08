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
    public class ClHouseholdDetailServiceController : ControllerBase
    {
        private readonly IClHouseholdDetailService ClHouseholdDetailService;
        public ClHouseholdDetailServiceController(IClHouseholdDetailService iClHouseholdDetailService)
        {
            ClHouseholdDetailService = iClHouseholdDetailService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClHouseholdDetail/GetClHouseholdDetail")]
        public IActionResult GetClHouseholdDetail()
        {
            try
            {
                List<ClHouseholdDetail> householdDetails = ClHouseholdDetailService.GetClHouseholdDetail().ToList();

                if (householdDetails != null && householdDetails.Any())
                {
                    return Ok(householdDetails);
                }
                else
                {
                    return BadRequest("No household detail(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClHouseholdDetail/AddClHouseholdDetail")]
        public IActionResult AddClHouseholdDetail(ClHouseholdDetail ClHouseholdDetail)
        {
            try
            {
                ClHouseholdDetail householdDetail = ClHouseholdDetailService.AddClHouseholdDetail(ClHouseholdDetail);

                if (householdDetail != null)
                {
                    return Ok(householdDetail);
                }
                else
                {
                    return BadRequest("Failed to add household detail.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClHouseholdDetail/UpdateClHouseholdDetail")]
        public IActionResult UpdateClHouseholdDetail(ClHouseholdDetail ClHouseholdDetail)
        {
            try
            {
                ClHouseholdDetail currentHouseholdDetail = ClHouseholdDetailService.GetClHouseholdDetailById(ClHouseholdDetail.HouseholdDetailsId);

                if (currentHouseholdDetail != null)
                {
                    #region Household Detail to update

                    currentHouseholdDetail.HouseholdDetailsId = ClHouseholdDetail.HouseholdDetailsId;
                    currentHouseholdDetail.ParticipantId = ClHouseholdDetail.ParticipantId;
                    currentHouseholdDetail.EasyAccess = ClHouseholdDetail.EasyAccess;
                    currentHouseholdDetail.Smokers = ClHouseholdDetail.Smokers;
                    currentHouseholdDetail.OffStreetParking = ClHouseholdDetail.OffStreetParking;
                    currentHouseholdDetail.EquipmentAvailable = ClHouseholdDetail.EquipmentAvailable;
                    currentHouseholdDetail.EquipmentDetails = ClHouseholdDetail.EquipmentDetails;
                    currentHouseholdDetail.Pets = ClHouseholdDetail.Pets;
                    currentHouseholdDetail.OtherPets = ClHouseholdDetail.OtherPets;

                    #endregion

                    ClHouseholdDetail householdDetail = ClHouseholdDetailService.UpdateClHouseholdDetail(currentHouseholdDetail);

                    if (householdDetail != null)
                    {
                        return Ok(householdDetail);
                    }
                    else
                    {
                        return BadRequest("Failed to update household detail.");
                    }
                }
                else
                {
                    return BadRequest("Household detail not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClHouseholdDetail/DeleteClHouseholdDetail")]
        public IActionResult DeleteClHouseholdDetail(int id)
        {
            try
            {
                ClHouseholdDetail currentHouseholdDetail = ClHouseholdDetailService.GetClHouseholdDetailById(id);

                if (currentHouseholdDetail != null)
                {
                    ClHouseholdDetail householdDetail = ClHouseholdDetailService.DeleteClHouseholdDetail(id);

                    return Ok(householdDetail);
                }
                else
                {
                    return BadRequest("Household detail not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClHouseholdDetail/GetClHouseholdDetailById")]
        public IActionResult GetClHouseholdDetailById(int id)
        {
            try
            {
                ClHouseholdDetail householdDetail = ClHouseholdDetailService.GetClHouseholdDetailById(id);

                if (householdDetail != null)
                {
                    return Ok(householdDetail);
                }
                else
                {
                    return BadRequest("Household detail not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
