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
    public class SwReferenceController : ControllerBase
    {
        private readonly ISwReferenceService SwReferenceServiceService;
        public SwReferenceController(ISwReferenceService iSwReferenceService)
        {
            SwReferenceServiceService = iSwReferenceService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwReference/GetSwReference")]
        public IEnumerable<SwReference> GetSwReference()
        {
            return SwReferenceServiceService.GetSwReference();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwReference/AddSwReference")]
        public SwReference AddSwReference(SwReference SwReference)
        {
            return SwReferenceServiceService.AddSwReference(SwReference);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwReference/UpdateSwReference")]
        public SwReference UpdateSwReference(SwReference SwReference)
        {
            return SwReferenceServiceService.UpdateSwReference(SwReference);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwReference/DeleteSwReference")]
        public SwReference DeleteSwReference(int id)
        {
            return SwReferenceServiceService.DeleteSwReference(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwReference/GetSwReferenceById")]
        public SwReference GetSwReferenceById(int id)
        {
            return SwReferenceServiceService.GetSwReferenceById(id);
        }
    }
}
