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
    public class ReligionController : ControllerBase
    {
        private readonly IReligionService ReligionServiceService;
        public ReligionController(IReligionService iReligionService)
        {
            ReligionServiceService = iReligionService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Religion/GetReligion")]
        public IEnumerable<Religion> GetReligion()
        {
            return ReligionServiceService.GetReligion();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Religion/AddReligion")]
        public Religion AddReligion(Religion Religion)
        {
            return ReligionServiceService.AddReligion(Religion);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/Religion/UpdateReligion")]
        public Religion UpdateReligion(Religion Religion)
        {
            return ReligionServiceService.UpdateReligion(Religion);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Religion/DeleteReligion")]
        public Religion DeleteReligion(int id)
        {
            return ReligionServiceService.DeleteReligion(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Religion/GetReligionById")]
        public Religion GetReligionById(int id)
        {
            return ReligionServiceService.GetReligionById(id);
        }
    }
}
