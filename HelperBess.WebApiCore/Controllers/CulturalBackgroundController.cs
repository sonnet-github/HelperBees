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

    public class CulturalBackgroundController : ControllerBase
    {
        private readonly ICulturalBackgroundService CulturalBackgroundServiceService;
        public CulturalBackgroundController(ICulturalBackgroundService iCulturalBackgroundService)
        {
            CulturalBackgroundServiceService = iCulturalBackgroundService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/CulturalBackground/GetCulturalBackground")]
        public IEnumerable<CulturalBackground> GetCulturalBackground()
        {
            return CulturalBackgroundServiceService.GetCulturalBackground();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/CulturalBackground/AddCulturalBackground")]
        public CulturalBackground AddCulturalBackground(CulturalBackground CulturalBackground)
        {
            return CulturalBackgroundServiceService.AddCulturalBackground(CulturalBackground);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/CulturalBackground/UpdateCulturalBackground")]
        public CulturalBackground UpdateCulturalBackground(CulturalBackground CulturalBackground)
        {
            return CulturalBackgroundServiceService.UpdateCulturalBackground(CulturalBackground);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/CulturalBackground/DeleteCulturalBackground")]
        public CulturalBackground DeleteCulturalBackground(int id)
        {
            return CulturalBackgroundServiceService.DeleteCulturalBackground(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/CulturalBackground/GetCulturalBackgroundById")]
        public CulturalBackground GetCulturalBackgroundById(int id)
        {
            return CulturalBackgroundServiceService.GetCulturalBackgroundById(id);
        }
    }
}
