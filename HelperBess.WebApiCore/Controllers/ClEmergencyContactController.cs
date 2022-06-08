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
    public class ClEmergencyContactController : ControllerBase
    {
        private readonly IClEmergencyContactService ClEmergencyContactService;
        public ClEmergencyContactController(IClEmergencyContactService iIClEmergencyContactService)
        {
            ClEmergencyContactService = iIClEmergencyContactService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClEmergencyContact/GetClEmergencyContact")]
        public IActionResult GetClEmergencyContact()
        {
            try
            {
                List<ClEmergencyContact> emergencyContacts = ClEmergencyContactService.GetClEmergencyContact().ToList();

                if (emergencyContacts != null && emergencyContacts.Any())
                {
                    return Ok(emergencyContacts);
                }
                else
                {
                    return BadRequest("No emergency contact(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClEmergencyContact/AddClEmergencyContact")]
        public IActionResult AddClEmergencyContact(ClEmergencyContact ClEmergencyContact)
        {
            try
            {
                ClEmergencyContact emergencyContact = ClEmergencyContactService.AddClEmergencyContact(ClEmergencyContact);

                if (emergencyContact != null)
                {
                    return Ok(emergencyContact);
                }
                else
                {
                    return BadRequest("Failed to add emergency contact.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClEmergencyContact/UpdateClEmergencyContact")]
        public IActionResult UpdateClEmergencyContact(ClEmergencyContact ClEmergencyContact)
        {
            try
            {
                ClEmergencyContact currentEmergencyContact = ClEmergencyContactService.GetClEmergencyContactById(ClEmergencyContact.EmergencyContactId);

                if (currentEmergencyContact != null)
                {
                    #region Emergency Contact to update

                    currentEmergencyContact.EmergencyContactId = ClEmergencyContact.EmergencyContactId;
                    currentEmergencyContact.ParticipantId = ClEmergencyContact.ParticipantId;
                    currentEmergencyContact.FirstName = ClEmergencyContact.FirstName;
                    currentEmergencyContact.LastName = ClEmergencyContact.LastName;
                    currentEmergencyContact.Phone = ClEmergencyContact.Phone;
                    currentEmergencyContact.EmailAddress = ClEmergencyContact.EmailAddress;
                    currentEmergencyContact.AddressStreet = ClEmergencyContact.AddressStreet;
                    currentEmergencyContact.AddressPostcode = ClEmergencyContact.AddressPostcode;
                    currentEmergencyContact.AddressSuburb = ClEmergencyContact.AddressSuburb;
                    currentEmergencyContact.AddressState = ClEmergencyContact.AddressState;
                    currentEmergencyContact.Relationship = ClEmergencyContact.Relationship;
                    currentEmergencyContact.EmergencyResponseAccessInformation = ClEmergencyContact.EmergencyResponseAccessInformation;
                    currentEmergencyContact.ShareInformation = ClEmergencyContact.ShareInformation;
                    currentEmergencyContact.CommuicationAuthority = ClEmergencyContact.CommuicationAuthority;

                    #endregion

                    ClEmergencyContact emergencyContact = ClEmergencyContactService.UpdateClEmergencyContact(currentEmergencyContact);

                    if (emergencyContact != null)
                    {
                        return Ok(emergencyContact);
                    }
                    else
                    {
                        return BadRequest("Failed to update emergency contact.");
                    }
                }
                else
                {
                    return BadRequest("Emergency contact not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClEmergencyContact/DeleteClEmergencyContact")]
        public IActionResult DeleteClEmergencyContact(int id)
        {
            try
            {
                ClEmergencyContact currentEmergencyContact = ClEmergencyContactService.GetClEmergencyContactById(id);

                if (currentEmergencyContact != null)
                {
                    ClEmergencyContact emergencyContact = ClEmergencyContactService.DeleteClEmergencyContact(id);

                    return Ok(emergencyContact);
                }
                else
                {
                    return BadRequest("Emergency contact not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClEmergencyContact/GetClEmergencyContactById")]
        public IActionResult GetClEmergencyContactById(int id)
        {
            try
            {
                ClEmergencyContact emergencyContact = ClEmergencyContactService.GetClEmergencyContactById(id);

                if (emergencyContact != null)
                {
                    return Ok(emergencyContact);
                }
                else
                {
                    return BadRequest("Emergency contact not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
