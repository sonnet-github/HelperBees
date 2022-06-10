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
    public class SwSupportWorkerBankAccountController : ControllerBase
    {
        private readonly ISwSupportWorkerBankAccountService SwSupportWorkerBankAccountServiceService;
        public SwSupportWorkerBankAccountController(ISwSupportWorkerBankAccountService iSwSupportWorkerBankAccountService)
        {
            SwSupportWorkerBankAccountServiceService = iSwSupportWorkerBankAccountService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerBankAccount/GetSwSupportWorkerBankAccount")]
        public IActionResult GetSwSupportWorkerBankAccount()
        {
            try
            {
                List<SwSupportWorkerBankAccount> swBankAccounts = SwSupportWorkerBankAccountServiceService.GetSwSupportWorkerBankAccount().ToList();

                if (swBankAccounts != null && swBankAccounts.Any())
                {
                    return Ok(swBankAccounts);
                }
                else
                {
                    return BadRequest("No support worker bank account(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerBankAccount/AddSwSupportWorkerBankAccount")]
        public IActionResult AddSwSupportWorkerBankAccount(SwSupportWorkerBankAccount SwSupportWorkerBankAccount)
        {
            try
            {
                SwSupportWorkerBankAccount swBankAccount = SwSupportWorkerBankAccountServiceService.AddSwSupportWorkerBankAccount(SwSupportWorkerBankAccount);

                if (swBankAccount != null)
                {
                    return Ok(swBankAccount);
                }
                else
                {
                    return BadRequest("Failed to add support worker bank account.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerBankAccount/UpdateSwSupportWorkerBankAccount")]
        public IActionResult UpdateSwSupportWorkerBankAccount(SwSupportWorkerBankAccount SwSupportWorkerBankAccount)
        {
            try
            {
                SwSupportWorkerBankAccount swCurrentBankAccount = SwSupportWorkerBankAccountServiceService.GetSwSupportWorkerBankAccountById(SwSupportWorkerBankAccount.BankAccountId);

                if (swCurrentBankAccount != null)
                {
                    swCurrentBankAccount.BankAccountId = SwSupportWorkerBankAccount.BankAccountId;
                    swCurrentBankAccount.SupportWorkerId = SwSupportWorkerBankAccount.SupportWorkerId;
                    swCurrentBankAccount.Dlnumber = SwSupportWorkerBankAccount.Dlnumber;
                    swCurrentBankAccount.AccountName = SwSupportWorkerBankAccount.AccountName;
                    swCurrentBankAccount.BankName = SwSupportWorkerBankAccount.BankName;
                    swCurrentBankAccount.Bsb = SwSupportWorkerBankAccount.Bsb;
                    swCurrentBankAccount.AccountNumber = SwSupportWorkerBankAccount.AccountNumber;

                    SwSupportWorkerBankAccount swBankAccount = SwSupportWorkerBankAccountServiceService.UpdateSwSupportWorkerBankAccount(swCurrentBankAccount);

                    if (swBankAccount != null)
                    {
                        return Ok(swBankAccount);
                    }
                    else
                    {
                        return BadRequest("Failed to update support worker bank account.");
                    }
                }
                else
                {
                    return BadRequest("Support worker bank account not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerBankAccount/DeleteSwSupportWorkerBankAccount")]
        public IActionResult DeleteSwSupportWorkerBankAccount(int id)
        {
            try
            {
                SwSupportWorkerBankAccount swCurrentBankAccount = SwSupportWorkerBankAccountServiceService.GetSwSupportWorkerBankAccountById(id);

                if (swCurrentBankAccount != null)
                {
                    SwSupportWorkerBankAccount swBankAccount = SwSupportWorkerBankAccountServiceService.DeleteSwSupportWorkerBankAccount(id);

                    return Ok(swBankAccount);
                }
                else
                {
                    return BadRequest("Support worker bank account not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerBankAccount/GetSwSupportWorkerBankAccountById")]
        public IActionResult GetSwSupportWorkerBankAccountById(int id)
        {
            try
            {
                SwSupportWorkerBankAccount swBankAccount = SwSupportWorkerBankAccountServiceService.GetSwSupportWorkerBankAccountById(id);

                if (swBankAccount != null)
                {
                    return Ok(swBankAccount);
                }
                else
                {
                    return BadRequest("Support worker bank account not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerBankAccount/GetSwSupportWorkerBankAccountBySupportWorkerId")]
        public IActionResult GetSwSupportWorkerBankAccountBySupportWorkerId(int supportWorkerId)
        {
            try
            {
                List<SwSupportWorkerBankAccount> swBankAccounts = SwSupportWorkerBankAccountServiceService.GetSwSupportWorkerBankAccountBySupportWorkerId(supportWorkerId)?.ToList();

                if (swBankAccounts != null && swBankAccounts.Any())
                {
                    return Ok(swBankAccounts);
                }
                else
                {
                    return NotFound("Support worker bank account not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
