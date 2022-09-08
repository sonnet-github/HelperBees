using Microsoft.AspNetCore.Mvc;
using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.Services
{
    [Route("api/[controller]")]
    [ApiController]
    [Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]
    public class AdministratorProfileController : ControllerBase
    {
        private readonly IAdministratorProfileService AdministratorProfileServiceService;
        public AdministratorProfileController(IAdministratorProfileService iAdministratorProfileService)
        {
            AdministratorProfileServiceService = iAdministratorProfileService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/AdministratorProfile/GetAdministratorProfile")]
        //[Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin": "http://mywebclient.azurewebsites.net", headers: "*", methods: "*")]
        public IEnumerable<AdministratorProfile> GetAdministratorProfile()
        {
            return AdministratorProfileServiceService.GetAdministratorProfile();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/AdministratorProfile/AddAdministratorProfile")]
        public AdministratorProfile AddAdministratorProfile(AdministratorProfile AdministratorProfile)
        {
            return AdministratorProfileServiceService.AddAdministratorProfile(AdministratorProfile);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/AdministratorProfile/UpdateAdministratorProfile")]
        public AdministratorProfile UpdateAdministratorProfile(AdministratorProfile AdministratorProfile)
        {
            return AdministratorProfileServiceService.UpdateAdministratorProfile(AdministratorProfile);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/AdministratorProfile/DeleteAdministratorProfile")]
        public AdministratorProfile DeleteAdministratorProfile(int id)
        {
            return AdministratorProfileServiceService.DeleteAdministratorProfile(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/AdministratorProfile/GetAdministratorProfileById")]
        public AdministratorProfile GetAdministratorProfileById(int id)
        {
            return AdministratorProfileServiceService.GetAdministratorProfileById(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/AdministratorProfile/GetAdministratorProfileByAdminId")]
        public AdministratorProfile GetAdministratorProfileByAdminId(int adminid)
        {
            return AdministratorProfileServiceService.GetAdministratorProfileByAdminId(adminid);
        }
    }
}
