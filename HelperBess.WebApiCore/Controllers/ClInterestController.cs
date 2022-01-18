using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.Controllers
{
    //////[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]
    public class ClInterestController : ControllerBase
    {
        private readonly IClInterestService ClInterestServiceService;
        public ClInterestController(IClInterestService iClInterestService)
        {
            ClInterestServiceService = iClInterestService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClInterest/GetClInterest")]
        public IEnumerable<ClInterest> GetClInterest()
        {
            return ClInterestServiceService.GetClInterest();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClInterest/AddClInterest")]
        public ClInterest AddClInterest(ClInterest ClInterest)
        {
            return ClInterestServiceService.AddClInterest(ClInterest);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClInterest/UpdateClInterest")]
        public ClInterest UpdateClInterest(ClInterest ClInterest)
        {
            return ClInterestServiceService.UpdateClInterest(ClInterest);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClInterest/DeleteClInterest")]
        public ClInterest DeleteClInterest(int id)
        {
            return ClInterestServiceService.DeleteClInterest(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClInterest/GetClInterestById")]
        public ClInterest GetClInterestById(int id)
        {
            return ClInterestServiceService.GetClInterestById(id);
        }
    }
}
