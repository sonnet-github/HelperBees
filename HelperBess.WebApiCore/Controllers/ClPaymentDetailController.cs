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
    public class ClPaymentDetailController : ControllerBase
    {
        private readonly IClPaymentDetailService ClPaymentDetailServiceService;
        public ClPaymentDetailController(IClPaymentDetailService iClPaymentDetailService)
        {
            ClPaymentDetailServiceService = iClPaymentDetailService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClPaymentDetail/GetClPaymentDetail")]
        public IEnumerable<ClPaymentDetail> GetClPaymentDetail()
        {
            return ClPaymentDetailServiceService.GetClPaymentDetail();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClPaymentDetail/AddClPaymentDetail")]
        public ClPaymentDetail AddClPaymentDetail(ClPaymentDetail ClPaymentDetail)
        {
            return ClPaymentDetailServiceService.AddClPaymentDetail(ClPaymentDetail);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClPaymentDetail/UpdateClPaymentDetail")]
        public ClPaymentDetail UpdateClPaymentDetail(ClPaymentDetail ClPaymentDetail)
        {
            return ClPaymentDetailServiceService.UpdateClPaymentDetail(ClPaymentDetail);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClPaymentDetail/DeleteClPaymentDetail")]
        public ClPaymentDetail DeleteClPaymentDetail(int id)
        {
            return ClPaymentDetailServiceService.DeleteClPaymentDetail(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClPaymentDetail/GetClPaymentDetailById")]
        public ClPaymentDetail GetClPaymentDetailById(int id)
        {
            return ClPaymentDetailServiceService.GetClPaymentDetailById(id);
        }
    }
}
