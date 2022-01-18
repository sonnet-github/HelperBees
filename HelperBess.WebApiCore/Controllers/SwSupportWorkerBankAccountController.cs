using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public IEnumerable<SwSupportWorkerBankAccount> GetSwSupportWorkerBankAccount()
        {
            return SwSupportWorkerBankAccountServiceService.GetSwSupportWorkerBankAccount();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerBankAccount/AddSwSupportWorkerBankAccount")]
        public SwSupportWorkerBankAccount AddSwSupportWorkerBankAccount(SwSupportWorkerBankAccount SwSupportWorkerBankAccount)
        {
            return SwSupportWorkerBankAccountServiceService.AddSwSupportWorkerBankAccount(SwSupportWorkerBankAccount);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerBankAccount/UpdateSwSupportWorkerBankAccount")]
        public SwSupportWorkerBankAccount UpdateSwSupportWorkerBankAccount(SwSupportWorkerBankAccount SwSupportWorkerBankAccount)
        {
            return SwSupportWorkerBankAccountServiceService.UpdateSwSupportWorkerBankAccount(SwSupportWorkerBankAccount);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerBankAccount/DeleteSwSupportWorkerBankAccount")]
        public SwSupportWorkerBankAccount DeleteSwSupportWorkerBankAccount(int id)
        {
            return SwSupportWorkerBankAccountServiceService.DeleteSwSupportWorkerBankAccount(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerBankAccount/GetSwSupportWorkerBankAccountById")]
        public SwSupportWorkerBankAccount GetSwSupportWorkerBankAccountById(int id)
        {
            return SwSupportWorkerBankAccountServiceService.GetSwSupportWorkerBankAccountById(id);
        }
    }
}
