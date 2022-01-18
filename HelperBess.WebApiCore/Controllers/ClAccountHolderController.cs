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
        public IEnumerable<ClAccountHolder> GetClAccountHolder(string emailaddress, string password)
        {
            return ClAccountHolderService.GetClAccountHolder(emailaddress, password);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClAccountHolder/GetClAccountHolderByEmailAddress")]
        public ClAccountHolder GetClAccountHolderByEmailAddress(string emailaddress)
        {
            return ClAccountHolderService.GetClAccountHolderByEmailAddress(emailaddress);
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClAccountHolder/AddClAccountHolder")]
        public ClAccountHolder AddClAccountHolder(ClAccountHolder ClAccountHolder)
        {
            return ClAccountHolderService.AddClAccountHolder(ClAccountHolder);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClAccountHolder/EditClAccountHolder")]
        public ClAccountHolder EditEmployee(ClAccountHolder ClAccountHolder)
        {
            return ClAccountHolderService.UpdateClAccountHolder(ClAccountHolder);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClAccountHolder/DeleteClAccountHolder")]
        public ClAccountHolder DeleteClAccountHolder(int id)
        {
            return ClAccountHolderService.DeleteClAccountHolder(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClAccountHolder/GetClAccountHolderById")]
        public ClAccountHolder GetClAccountHolderById(int id)
        {
            return ClAccountHolderService.GetClAccountHolderById(id);
        }
    }
}
