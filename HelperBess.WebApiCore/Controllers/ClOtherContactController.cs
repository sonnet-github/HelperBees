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
    public class ClOtherContactController : ControllerBase
    {
        private readonly IClOtherContactService ClOtherContactServiceService;
        public ClOtherContactController(IClOtherContactService iClOtherContactService)
        {
            ClOtherContactServiceService = iClOtherContactService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClOtherContact/GetClOtherContact")]
        public IActionResult GetClOtherContact()
        {
            try
            {
                List<ClOtherContact> otherContacts = ClOtherContactServiceService.GetClOtherContact().ToList();

                if (otherContacts != null && otherContacts.Any())
                {
                    return Ok(otherContacts);
                }
                else
                {
                    return BadRequest("No other contact(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClOtherContact/AddClOtherContact")]
        public IActionResult AddClOtherContact(ClOtherContact ClOtherContact)
        {
            try
            {
                ClOtherContact otherContact = ClOtherContactServiceService.AddClOtherContact(ClOtherContact);

                if (otherContact != null)
                {
                    return Ok(otherContact);
                }
                else
                {
                    return BadRequest("Failed to add other contact.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClOtherContact/UpdateClOtherContact")]
        public IActionResult UpdateClOtherContact(ClOtherContact ClOtherContact)
        {
            try
            {
                ClOtherContact currentOtherContact = ClOtherContactServiceService.GetClOtherContactById(ClOtherContact.OtherContactId);

                if (currentOtherContact != null)
                {
                    #region Other Contact to update

                    currentOtherContact.OtherContactId = ClOtherContact.OtherContactId;
                    currentOtherContact.ParticipantId = ClOtherContact.ParticipantId;
                    currentOtherContact.FirstName = ClOtherContact.FirstName;
                    currentOtherContact.LastName = ClOtherContact.LastName;
                    currentOtherContact.Phone = ClOtherContact.Phone;
                    currentOtherContact.EmailAddress = ClOtherContact.EmailAddress;
                    currentOtherContact.Relationship = ClOtherContact.Relationship;

                    #endregion

                    ClOtherContact otherContact = ClOtherContactServiceService.UpdateClOtherContact(currentOtherContact);

                    if (otherContact != null)
                    {
                        return Ok(otherContact);
                    }
                    else
                    {
                        return BadRequest("Failed to update other contact.");
                    }
                }
                else
                {
                    return BadRequest("Other contact not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClOtherContact/DeleteClOtherContact")]
        public IActionResult DeleteClOtherContact(int id)
        {
            try
            {
                ClOtherContact currentOtherContact = ClOtherContactServiceService.GetClOtherContactById(id);

                if (currentOtherContact != null)
                {
                    ClOtherContact otherContact = ClOtherContactServiceService.DeleteClOtherContact(id);

                    return Ok(otherContact);
                }
                else
                {
                    return BadRequest("Other Contact not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClOtherContact/GetClOtherContactById")]
        public IActionResult GetClOtherContactById(int id)
        {
            try
            {
                ClOtherContact otherContact = ClOtherContactServiceService.GetClOtherContactById(id);

                if (otherContact != null)
                {
                    return Ok(otherContact);
                }
                else
                {
                    return BadRequest("Other contact not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
