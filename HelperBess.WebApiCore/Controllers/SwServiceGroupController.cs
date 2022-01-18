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
    public class SwServiceGroupController : ControllerBase
    {
        private readonly ISwServiceGroupService SwServiceGroupServiceService;
        public SwServiceGroupController(ISwServiceGroupService iSwServiceGroupService)
        {
            SwServiceGroupServiceService = iSwServiceGroupService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwServiceGroup/GetSwServiceGroup")]
        public IEnumerable<SwServiceGroup> GetSwServiceGroup()
        {
            return SwServiceGroupServiceService.GetSwServiceGroup();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwServiceGroup/AddSwServiceGroup")]
        public SwServiceGroup AddSwServiceGroup(SwServiceGroup SwServiceGroup)
        {
            return SwServiceGroupServiceService.AddSwServiceGroup(SwServiceGroup);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwServiceGroup/UpdateSwServiceGroup")]
        public SwServiceGroup UpdateSwServiceGroup(SwServiceGroup SwServiceGroup)
        {
            return SwServiceGroupServiceService.UpdateSwServiceGroup(SwServiceGroup);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwServiceGroup/DeleteSwServiceGroup")]
        public SwServiceGroup DeleteSwServiceGroup(int id)
        {
            return SwServiceGroupServiceService.DeleteSwServiceGroup(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwServiceGroup/GetSwServiceGroupById")]
        public SwServiceGroup GetSwServiceGroupById(int id)
        {
            return SwServiceGroupServiceService.GetSwServiceGroupById(id);
        }
    }
}
