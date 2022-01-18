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
    public class ClJobServiceController : ControllerBase
    {
        private readonly IClJobServiceService ClJobServiceServiceService;
        public ClJobServiceController(IClJobServiceService iClJobServiceService)
        {
            ClJobServiceServiceService = iClJobServiceService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClJobService/GetClJobService")]
        public IEnumerable<ClJobService> GetClJobService()
        {
            return ClJobServiceServiceService.GetClJobService();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClJobService/AddClJobService")]
        public ClJobService AddClJobService(ClJobService ClJobService)
        {
            return ClJobServiceServiceService.AddClJobService(ClJobService);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClJobService/UpdateClJobService")]
        public ClJobService UpdateClJobService(ClJobService ClJobService)
        {
            return ClJobServiceServiceService.UpdateClJobService(ClJobService);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClJobService/DeleteClJobService")]
        public ClJobService DeleteClJobService(int id)
        {
            return ClJobServiceServiceService.DeleteClJobService(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClJobService/GetClJobServiceById")]
        public ClJobService GetClJobServiceById(int id)
        {
            return ClJobServiceServiceService.GetClJobServiceById(id);
        }
    }
}
