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
    public class ClHouseholdDetailServiceController : ControllerBase
    {
        private readonly IClHouseholdDetailService ClHouseholdDetailService;
        public ClHouseholdDetailServiceController(IClHouseholdDetailService iClHouseholdDetailService)
        {
            ClHouseholdDetailService = iClHouseholdDetailService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClHouseholdDetail/GetClHouseholdDetail")]
        public IEnumerable<ClHouseholdDetail> GetClHouseholdDetail()
        {
            return ClHouseholdDetailService.GetClHouseholdDetail();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClHouseholdDetail/AddClHouseholdDetail")]
        public ClHouseholdDetail AddClHouseholdDetail(ClHouseholdDetail ClHouseholdDetail)
        {
            return ClHouseholdDetailService.AddClHouseholdDetail(ClHouseholdDetail);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClHouseholdDetail/UpdateClHouseholdDetail")]
        public ClHouseholdDetail UpdateClHouseholdDetail(ClHouseholdDetail ClHouseholdDetail)
        {
            return ClHouseholdDetailService.UpdateClHouseholdDetail(ClHouseholdDetail);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClHouseholdDetail/DeleteClHouseholdDetail")]
        public ClHouseholdDetail DeleteClHouseholdDetail(int id)
        {
            return ClHouseholdDetailService.DeleteClHouseholdDetail(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClHouseholdDetail/GetClHouseholdDetailById")]
        public ClHouseholdDetail GetClHouseholdDetailById(int id)
        {
            return ClHouseholdDetailService.GetClHouseholdDetailById(id);
        }
    }
}
