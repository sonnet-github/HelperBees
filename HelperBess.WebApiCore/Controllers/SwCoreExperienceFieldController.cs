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
    public class SwCoreExperienceFieldController : ControllerBase
    {
        private readonly ISwCoreExperienceFieldService SwCoreExperienceFieldServiceService;
        public SwCoreExperienceFieldController(ISwCoreExperienceFieldService iSwCoreExperienceFieldService)
        {
            SwCoreExperienceFieldServiceService = iSwCoreExperienceFieldService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwCoreExperienceField/GetSwCoreExperienceField")]
        public IEnumerable<SwCoreExperienceField> GetSwCoreExperienceField()
        {
            return SwCoreExperienceFieldServiceService.GetSwCoreExperienceField();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwCoreExperienceField/AddSwCoreExperienceField")]
        public SwCoreExperienceField AddSwCoreExperienceField(SwCoreExperienceField SwCoreExperienceField)
        {
            return SwCoreExperienceFieldServiceService.AddSwCoreExperienceField(SwCoreExperienceField);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwCoreExperienceField/UpdateSwCoreExperienceField")]
        public SwCoreExperienceField UpdateSwCoreExperienceField(SwCoreExperienceField SwCoreExperienceField)
        {
            return SwCoreExperienceFieldServiceService.UpdateSwCoreExperienceField(SwCoreExperienceField);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwCoreExperienceField/DeleteSwCoreExperienceField")]
        public SwCoreExperienceField DeleteSwCoreExperienceField(int id)
        {
            return SwCoreExperienceFieldServiceService.DeleteSwCoreExperienceField(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwCoreExperienceField/GetSwCoreExperienceFieldById")]
        public SwCoreExperienceField GetSwCoreExperienceFieldById(int id)
        {
            return SwCoreExperienceFieldServiceService.GetSwCoreExperienceFieldById(id);
        }
    }
}
