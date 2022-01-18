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
    public class SwInsuranceDeclarationController : ControllerBase
    {
        private readonly ISwInsuranceDeclarationService SwInsuranceDeclarationServiceService;
        public SwInsuranceDeclarationController(ISwInsuranceDeclarationService iSwInsuranceDeclarationService)
        {
            SwInsuranceDeclarationServiceService = iSwInsuranceDeclarationService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwInsuranceDeclaration/GetSwInsuranceDeclaration")]
        public IEnumerable<SwInsuranceDeclaration> GetSwInsuranceDeclaration()
        {
            return SwInsuranceDeclarationServiceService.GetSwInsuranceDeclaration();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwInsuranceDeclaration/AddSwInsuranceDeclaration")]
        public SwInsuranceDeclaration AddSwInsuranceDeclaration(SwInsuranceDeclaration SwInsuranceDeclaration)
        {
            return SwInsuranceDeclarationServiceService.AddSwInsuranceDeclaration(SwInsuranceDeclaration);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwInsuranceDeclaration/UpdateSwInsuranceDeclaration")]
        public SwInsuranceDeclaration UpdateSwInsuranceDeclaration(SwInsuranceDeclaration SwInsuranceDeclaration)
        {
            return SwInsuranceDeclarationServiceService.UpdateSwInsuranceDeclaration(SwInsuranceDeclaration);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwInsuranceDeclaration/DeleteSwInsuranceDeclaration")]
        public SwInsuranceDeclaration DeleteSwInsuranceDeclaration(int id)
        {
            return SwInsuranceDeclarationServiceService.DeleteSwInsuranceDeclaration(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwInsuranceDeclaration/GetSwInsuranceDeclarationById")]
        public SwInsuranceDeclaration GetSwInsuranceDeclarationById(int id)
        {
            return SwInsuranceDeclarationServiceService.GetSwInsuranceDeclarationById(id);
        }
    }
}
