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
    public class ClAccountHolderProfileController : ControllerBase
    {
        private readonly IClAccountHolderProfileService ClAccountHolderProfileService;
        public ClAccountHolderProfileController(IClAccountHolderProfileService iClAccountHolderProfileService)
        {
            ClAccountHolderProfileService = iClAccountHolderProfileService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClAccountHolderProfile/GetClAccountHolderProfile")]
        public IActionResult GetClAccountHolderProfile()
        {
            try
            {
                List<ClAccountHolderProfile> profiles = ClAccountHolderProfileService.GetClAccountHolderProfile().ToList();

                if (profiles != null && profiles.Any())
                {
                    return Ok(profiles);
                }
                else
                {
                    return BadRequest("No account holder profile(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClAccountHolderProfile/AddClAccountHolderProfile")]
        public IActionResult AddClAccountHolderProfile(ClAccountHolderProfile ClAccountHolderProfile)
        {
            try
            {
                ClAccountHolderProfile profile = ClAccountHolderProfileService.AddClAccountHolderProfile(ClAccountHolderProfile);

                if (profile != null)
                {
                    return Ok(profile);
                }
                else
                {
                    return BadRequest("Failed to add account holder profile.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClAccountHolderProfile/UpdateClAccountHolderProfile")]
        public IActionResult UpdateClAccountHolderProfile(ClAccountHolderProfile ClAccountHolderProfile)
        {
            try
            {
                ClAccountHolderProfile currentProfile = ClAccountHolderProfileService.GetClAccountHolderProfileById(ClAccountHolderProfile.AccountHolderProfileId);

                if (currentProfile != null)
                {
                    currentProfile.AccountHolderProfileId = ClAccountHolderProfile.AccountHolderProfileId;
                    currentProfile.AccountHolderId = ClAccountHolderProfile.AccountHolderId;
                    currentProfile.IsPersonNeedingSupport = ClAccountHolderProfile.IsPersonNeedingSupport;
                    currentProfile.RelationshipToPersonNeedingSupport = ClAccountHolderProfile.RelationshipToPersonNeedingSupport;
                    currentProfile.FirstName = ClAccountHolderProfile.FirstName;
                    currentProfile.LastName = ClAccountHolderProfile.LastName;
                    currentProfile.Gender = ClAccountHolderProfile.Gender;
                    currentProfile.GenderOther = ClAccountHolderProfile.GenderOther;
                    currentProfile.Phone = ClAccountHolderProfile.Phone;
                    currentProfile.Birthdate = ClAccountHolderProfile.Birthdate;
                    currentProfile.AddressStreet = ClAccountHolderProfile.AddressStreet;
                    currentProfile.AddressPostcode = ClAccountHolderProfile.AddressPostcode;
                    currentProfile.AddressSuburb = ClAccountHolderProfile.AddressSuburb;
                    currentProfile.AddressState = ClAccountHolderProfile.AddressState;
                    currentProfile.Mobile = ClAccountHolderProfile.Mobile;
                    currentProfile.CareAtThisAddress = ClAccountHolderProfile.CareAtThisAddress;
                    currentProfile.LivingWith = ClAccountHolderProfile.LivingWith;
                    currentProfile.LivingWithPerson = ClAccountHolderProfile.LivingWithPerson;


        ClAccountHolderProfile profile = ClAccountHolderProfileService.UpdateClAccountHolderProfile(currentProfile);

                    if (profile != null)
                    {
                        return Ok(profile);
                    }
                    else
                    {
                        return BadRequest("Failed to update account holder profile.");
                    }
                }
                else
                {
                    return BadRequest("Account holder profile not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClAccountHolderProfile/DeleteClAccountHolderProfile")]
        public IActionResult DeleteClAccountHolderProfile(int id)
        {
            try
            {
                ClAccountHolderProfile currentProfile = ClAccountHolderProfileService.GetClAccountHolderProfileById(id);

                if (currentProfile != null)
                {
                    ClAccountHolderProfile profile = ClAccountHolderProfileService.DeleteClAccountHolderProfile(id);

                    return Ok(profile);                    
                }
                else
                {
                    return BadRequest("Account holder profile not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClAccountHolderProfile/GetClAccountHolderProfileById")]
        public IActionResult GetClAccountHolderProfileById(int id)
        {
            try
            {
                ClAccountHolderProfile profile = ClAccountHolderProfileService.GetClAccountHolderProfileById(id);

                
                if (profile != null)
                {
                    return Ok(profile);
                }                    
                else
                {
                    return BadRequest("Account holder profile not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClAccountHolderProfile/GetClAccountHolderProfileByAccountHolder")]
        public IActionResult GetClAccountHolderProfileByAccountHolder(int accountHolderId)
        {
            try
            {
                ClAccountHolderProfile profile = ClAccountHolderProfileService.GetClAccountHolderProfileByAccountHolder(accountHolderId);


                if (profile != null)
                {
                    return Ok(profile);
                }
                else
                {
                    return BadRequest("Account holder profile not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
