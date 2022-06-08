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
    public class CIAccountHolderController : ControllerBase
    {
        private readonly IClAccountHolderService ClAccountHolderService;
        public CIAccountHolderController(IClAccountHolderService iClAccountHolderService)
        {
            ClAccountHolderService = iClAccountHolderService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClAccountHolder/GetClAccountHolder")]
        public IActionResult GetClAccountHolder(string emailaddress, string password)
        {
            try
            {
                List<ClAccountHolder> accounts = ClAccountHolderService.GetClAccountHolder(emailaddress, password).ToList();

                if (accounts != null && accounts.Any())
                {
                    return Ok(accounts);
                }
                else
                {
                    return BadRequest("Account holder(s) not found.");
                }
            }
            catch(Exception  ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClAccountHolder/GetClAccountHolderByEmailAddress")]
        public IActionResult GetClAccountHolderByEmailAddress(string emailaddress)
        {
            try
            {
                ClAccountHolder account = ClAccountHolderService.GetClAccountHolderByEmailAddress(emailaddress);

                if (account != null)
                {
                    return Ok(account);
                }
                else
                {
                    return BadRequest("Account holder not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClAccountHolder/AddClAccountHolder")]
        public IActionResult AddClAccountHolder(ClAccountHolder ClAccountHolder)
        {
            try
            {
                ClAccountHolder currentAccount = ClAccountHolderService.GetClAccountHolderByEmailAddress(ClAccountHolder.EmailAddress);

                if (currentAccount == null)
                {
                    ClAccountHolder account = ClAccountHolderService.AddClAccountHolder(ClAccountHolder);

                    if (account != null)
                    {
                        return Ok(account);
                    }
                    else
                    {
                        return BadRequest("Failed to add account holder.");
                    }
                }
                else
                {
                    return BadRequest($"E-mail address {ClAccountHolder.EmailAddress} is already use by another account holder.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClAccountHolder/EditClAccountHolder")]
        public IActionResult EditEmployee(ClAccountHolder ClAccountHolder)
        {
            try
            {
                ClAccountHolder currentAccount = ClAccountHolderService.GetClAccountHolderById(ClAccountHolder.AccountHolderId);

                if (currentAccount != null)
                {
                    currentAccount.AccountHolderId = ClAccountHolder.AccountHolderId;
                    currentAccount.EmailAddress = ClAccountHolder.EmailAddress;
                    currentAccount.Password = ClAccountHolder.Password;
                    currentAccount.FailedLoginCount = ClAccountHolder.FailedLoginCount;
                    currentAccount.DateCreated = ClAccountHolder.DateCreated;
                    currentAccount.StatusId = ClAccountHolder.StatusId != 0 ? ClAccountHolder.StatusId : null;
                    currentAccount.Locked = ClAccountHolder.Locked;
                    currentAccount.Active = ClAccountHolder.Active;
                    
                    ClAccountHolder account = ClAccountHolderService.UpdateClAccountHolder(currentAccount);

                    if (account != null)
                    {
                        return Ok(account);
                    }
                    else
                    {
                        return BadRequest("Failed to add account holder.");
                    }
                }
                else
                {
                    return BadRequest("Account holder not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClAccountHolder/DeleteClAccountHolder")]
        public IActionResult DeleteClAccountHolder(int id)
        {
            try
            {
                ClAccountHolder currentAccount = ClAccountHolderService.DeleteClAccountHolder(id);

                if (currentAccount != null)
                {
                    ClAccountHolder account = ClAccountHolderService.DeleteClAccountHolder(id);

                    return Ok(account);
                }
                else
                {
                    return BadRequest("Account holder not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClAccountHolder/GetClAccountHolderById")]
        public IActionResult GetClAccountHolderById(int id)
        {
            try
            {
                ClAccountHolder account = ClAccountHolderService.GetClAccountHolderById(id);

                if (account != null)
                {
                    return Ok(account);
                }
                else
                {
                    return BadRequest("Account holder not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
