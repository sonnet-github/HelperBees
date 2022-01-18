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
        public IEnumerable<ClOtherContact> GetClOtherContact()
        {
            return ClOtherContactServiceService.GetClOtherContact();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClOtherContact/AddClOtherContact")]
        public ClOtherContact AddClOtherContact(ClOtherContact ClOtherContact)
        {
            return ClOtherContactServiceService.AddClOtherContact(ClOtherContact);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClOtherContact/UpdateClOtherContact")]
        public ClOtherContact UpdateClOtherContact(ClOtherContact ClOtherContact)
        {
            return ClOtherContactServiceService.UpdateClOtherContact(ClOtherContact);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClOtherContact/DeleteClOtherContact")]
        public ClOtherContact DeleteClOtherContact(int id)
        {
            return ClOtherContactServiceService.DeleteClOtherContact(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClOtherContact/GetClOtherContactById")]
        public ClOtherContact GetClOtherContactById(int id)
        {
            return ClOtherContactServiceService.GetClOtherContactById(id);
        }
    }
}
