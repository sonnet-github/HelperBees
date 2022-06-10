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
    public class SwSupportWorkerProfileController : ControllerBase
    {
        private readonly ISwSupportWorkerProfileService SwSupportWorkerProfileServiceService;
        public SwSupportWorkerProfileController(ISwSupportWorkerProfileService iSwSupportWorkerProfileService)
        {
            SwSupportWorkerProfileServiceService = iSwSupportWorkerProfileService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerProfile/GetSwSupportWorkerProfile")]
        public IActionResult GetSwSupportWorkerProfile()
        {
            try
            {
                List<SwSupportWorkerProfile> swProfiles = SwSupportWorkerProfileServiceService.GetSwSupportWorkerProfile().ToList();

                if (swProfiles != null && swProfiles.Any())
                {
                    return Ok(swProfiles);
                }
                else
                {
                    return BadRequest("No support worker profile(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerProfile/GetSwSupportWorkerProfileByLocation")]
        public IActionResult GetSwSupportWorkerProfileByLocation(string location)
        {
            try
            {
                List<SwSupportWorkerProfile> swProfiles = SwSupportWorkerProfileServiceService.GetSwSupportWorkerProfileByLocation(location).ToList();

                if (swProfiles != null && swProfiles.Any())
                {
                    return Ok(swProfiles);
                }
                else
                {
                    return BadRequest("No support worker profile(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerProfile/AddSwSupportWorkerProfile")]
        public IActionResult AddSwSupportWorkerProfile(SwSupportWorkerProfile SwSupportWorkerProfile)
        {
            try
            {
                SwSupportWorkerProfile swProfile = SwSupportWorkerProfileServiceService.AddSwSupportWorkerProfile(SwSupportWorkerProfile);

                if (swProfile != null)
                {
                    return Ok(swProfile);
                }
                else
                {
                    return BadRequest("Failed to add support worker profile.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerProfile/UpdateSwSupportWorkerProfile")]
        public IActionResult UpdateSwSupportWorkerProfile(SwSupportWorkerProfile SwSupportWorkerProfile)
        {
            try
            {
                SwSupportWorkerProfile swCurrentProfile = SwSupportWorkerProfileServiceService.GetSwSupportWorkerProfileById(SwSupportWorkerProfile.SupportWorkerProfileId);

                if (swCurrentProfile != null)
                {
                    #region Profile to update

                    swCurrentProfile.SupportWorkerProfileId = SwSupportWorkerProfile.SupportWorkerProfileId;
                    swCurrentProfile.SupportWorkerId = SwSupportWorkerProfile.SupportWorkerId;
                    swCurrentProfile.FirstName = SwSupportWorkerProfile.FirstName;
                    swCurrentProfile.LastName = SwSupportWorkerProfile.LastName;
                    swCurrentProfile.LegalName = SwSupportWorkerProfile.LegalName;
                    swCurrentProfile.FriendlyName = SwSupportWorkerProfile.FriendlyName;
                    swCurrentProfile.Bio = SwSupportWorkerProfile.Bio;
                    swCurrentProfile.CompanyPartnershipDetails = SwSupportWorkerProfile.CompanyPartnershipDetails;
                    swCurrentProfile.CompanyName = SwSupportWorkerProfile.CompanyName;
                    swCurrentProfile.PartnershipName = SwSupportWorkerProfile.PartnershipName;
                    swCurrentProfile.InvoiceType = SwSupportWorkerProfile.InvoiceType;
                    swCurrentProfile.ProfilePhotoURL = SwSupportWorkerProfile.ProfilePhotoURL;
                    swCurrentProfile.Sex = SwSupportWorkerProfile.Sex;
                    swCurrentProfile.SexOther = SwSupportWorkerProfile.SexOther;
                    swCurrentProfile.Birthdate = SwSupportWorkerProfile.Birthdate;
                    swCurrentProfile.Phone = SwSupportWorkerProfile.Phone;
                    swCurrentProfile.ResAddrUnitNumber = SwSupportWorkerProfile.ResAddrUnitNumber;
                    swCurrentProfile.ResAddrStreet = SwSupportWorkerProfile.ResAddrStreet;
                    swCurrentProfile.ResAddrSuburb = SwSupportWorkerProfile.ResAddrSuburb;
                    swCurrentProfile.ResAddrState = SwSupportWorkerProfile.ResAddrState;
                    swCurrentProfile.ResAddrCountry = SwSupportWorkerProfile.ResAddrCountry;
                    swCurrentProfile.PostAddrSameAsResAddr = SwSupportWorkerProfile.PostAddrSameAsResAddr;
                    swCurrentProfile.PostAddrUnitNumber = SwSupportWorkerProfile.PostAddrUnitNumber;
                    swCurrentProfile.PostAddrStreet = SwSupportWorkerProfile.PostAddrStreet;
                    swCurrentProfile.PostAddrSuburb = SwSupportWorkerProfile.PostAddrSuburb;
                    swCurrentProfile.PostAddrState = SwSupportWorkerProfile.PostAddrState;
                    swCurrentProfile.PostAddrCountry = SwSupportWorkerProfile.PostAddrCountry;
                    swCurrentProfile.ABN = SwSupportWorkerProfile.ABN;
                    swCurrentProfile.InterestsAndHobbies = SwSupportWorkerProfile.InterestsAndHobbies;
                    swCurrentProfile.Personality = SwSupportWorkerProfile.Personality;
                    swCurrentProfile.PersonalityAdditional = SwSupportWorkerProfile.PersonalityAdditional;
                    swCurrentProfile.PetFriendly = SwSupportWorkerProfile.PetFriendly;
                    swCurrentProfile.NonSmoker = SwSupportWorkerProfile.NonSmoker;
                    swCurrentProfile.PreferToWorkWith = SwSupportWorkerProfile.PreferToWorkWith;
                    swCurrentProfile.AHRPARegistrationNumber = SwSupportWorkerProfile.AHRPARegistrationNumber;
                    swCurrentProfile.AHRPAExpiryDate = SwSupportWorkerProfile.AHRPAExpiryDate;
                    swCurrentProfile.AHPRARegistrationActiveConfirm = SwSupportWorkerProfile.AHPRARegistrationActiveConfirm;
                    swCurrentProfile.ProvideTransportServices = SwSupportWorkerProfile.ProvideTransportServices;

                    #endregion

                    SwSupportWorkerProfile swProfile = SwSupportWorkerProfileServiceService.UpdateSwSupportWorkerProfile(swCurrentProfile);

                    if (swProfile != null)
                    {
                        return Ok(swProfile);
                    }
                    else
                    {
                        return BadRequest("Failed to update support worker profile.");
                    }
                }
                else
                {
                    return BadRequest("Support worker profile not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerProfile/DeleteSwSupportWorkerProfile")]
        public IActionResult DeleteSwSupportWorkerProfile(int id)
        {
            try
            {
                SwSupportWorkerProfile swCurrentProfile = SwSupportWorkerProfileServiceService.GetSwSupportWorkerProfileById(id);

                if (swCurrentProfile != null)
                {
                    SwSupportWorkerProfile swProfile = SwSupportWorkerProfileServiceService.DeleteSwSupportWorkerProfile(id);

                    return Ok(swProfile);
                }
                else
                {
                    return BadRequest("Support worker profile not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerProfile/GetSwSupportWorkerProfileById")]
        public IActionResult GetSwSupportWorkerProfileById(int id)
        {
            try
            {
                SwSupportWorkerProfile swProfile = SwSupportWorkerProfileServiceService.GetSwSupportWorkerProfileById(id);

                if (swProfile != null)
                {
                    return Ok(swProfile);
                }
                else
                {
                    return BadRequest("Support worker profile not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerProfile/GetSwSupportWorkerProfileBySupportWorkerId")]
        public IActionResult GetSwSupportWorkerProfileBySupportWorkerId(int supportWorkerId)
        {
            try
            {
                List<SwSupportWorkerProfile> swProfiles = SwSupportWorkerProfileServiceService.GetSwSupportWorkerProfileBySupportWorkerId(supportWorkerId)?.ToList();

                if (swProfiles != null && swProfiles.Any())
                {
                    return Ok(swProfiles);
                }
                else
                {
                    return NotFound("Support worker profile not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
