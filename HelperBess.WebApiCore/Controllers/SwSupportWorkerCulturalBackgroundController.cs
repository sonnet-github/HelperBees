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
    public class SwSupportWorkerCulturalBackgroundController : Controller
    {
        private readonly ISwSupportWorkerCulturalBackgroundService SwSupportWorkerCulturalBackgroundServiceService;
        public SwSupportWorkerCulturalBackgroundController(ISwSupportWorkerCulturalBackgroundService iSwSupportWorkerCulturalBackgroundService)
        {
            SwSupportWorkerCulturalBackgroundServiceService = iSwSupportWorkerCulturalBackgroundService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerCulturalBackground/GetSwSupportWorkerCulturalBackground")]
        public IEnumerable<SwSupportWorkerCulturalBackground> GetSwSupportWorkerCulturalBackground()
        {
            return SwSupportWorkerCulturalBackgroundServiceService.GetSwSupportWorkerCulturalBackground();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorkerCulturalBackground/AddSwSupportWorkerCulturalBackground")]
        public SwSupportWorkerCulturalBackground AddSwSupportWorkerCulturalBackground(SwSupportWorkerCulturalBackground SwSupportWorkerCulturalBackground)
        {
            return SwSupportWorkerCulturalBackgroundServiceService.AddSwSupportWorkerCulturalBackground(SwSupportWorkerCulturalBackground);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorkerCulturalBackground/UpdateSwSupportWorkerCulturalBackground")]
        public SwSupportWorkerCulturalBackground UpdateSwSupportWorkerCulturalBackground(SwSupportWorkerCulturalBackground SwSupportWorkerCulturalBackground)
        {
            return SwSupportWorkerCulturalBackgroundServiceService.UpdateSwSupportWorkerCulturalBackground(SwSupportWorkerCulturalBackground);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorkerCulturalBackground/DeleteSwSupportWorkerCulturalBackground")]
        public SwSupportWorkerCulturalBackground DeleteSwSupportWorkerCulturalBackground(int id)
        {
            return SwSupportWorkerCulturalBackgroundServiceService.DeleteSwSupportWorkerCulturalBackground(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorkerCulturalBackground/GetSwSupportWorkerCulturalBackgroundById")]
        public SwSupportWorkerCulturalBackground GetSwSupportWorkerCulturalBackgroundById(int id)
        {
            return SwSupportWorkerCulturalBackgroundServiceService.GetSwSupportWorkerCulturalBackgroundById(id);
        }
    }
}
