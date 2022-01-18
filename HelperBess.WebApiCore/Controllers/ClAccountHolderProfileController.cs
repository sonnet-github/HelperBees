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
        public IEnumerable<ClAccountHolderProfile> GetClAccountHolderProfile()
        {
            return ClAccountHolderProfileService.GetClAccountHolderProfile();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClAccountHolderProfile/AddClAccountHolderProfile")]
        public ClAccountHolderProfile AddClAccountHolderProfile(ClAccountHolderProfile ClAccountHolderProfile)
        {
            return ClAccountHolderProfileService.AddClAccountHolderProfile(ClAccountHolderProfile);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClAccountHolderProfile/UpdateClAccountHolderProfile")]
        public ClAccountHolderProfile UpdateClAccountHolderProfile(ClAccountHolderProfile ClAccountHolderProfile)
        {
            return ClAccountHolderProfileService.UpdateClAccountHolderProfile(ClAccountHolderProfile);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClAccountHolderProfile/DeleteClAccountHolderProfile")]
        public ClAccountHolderProfile DeleteClAccountHolderProfile(int id)
        {
            return ClAccountHolderProfileService.DeleteClAccountHolderProfile(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClAccountHolderProfile/GetClAccountHolderProfileById")]
        public ClAccountHolderProfile GetClAccountHolderProfileById(int id)
        {
            return ClAccountHolderProfileService.GetClAccountHolderProfileById(id);
        }
    }
}
