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
    public class SwWorkHistoryController : ControllerBase
    {
        private readonly ISwWorkHistoryService SwWorkHistoryServiceService;
        public SwWorkHistoryController(ISwWorkHistoryService iSwWorkHistoryService)
        {
            SwWorkHistoryServiceService = iSwWorkHistoryService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwWorkHistory/GetSwWorkHistory")]
        public IEnumerable<SwWorkHistory> GetSwWorkHistory()
        {
            return SwWorkHistoryServiceService.GetSwWorkHistory();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwWorkHistory/AddSwWorkHistory")]
        public SwWorkHistory AddSwWorkHistory(SwWorkHistory SwWorkHistory)
        {
            return SwWorkHistoryServiceService.AddSwWorkHistory(SwWorkHistory);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwWorkHistory/UpdateSwWorkHistory")]
        public SwWorkHistory UpdateSwWorkHistory(SwWorkHistory SwWorkHistory)
        {
            return SwWorkHistoryServiceService.UpdateSwWorkHistory(SwWorkHistory);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwWorkHistory/DeleteSwWorkHistory")]
        public SwWorkHistory DeleteSwWorkHistory(int id)
        {
            return SwWorkHistoryServiceService.DeleteSwWorkHistory(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwWorkHistory/GetSwWorkHistoryById")]
        public SwWorkHistory GetSwWorkHistoryById(int id)
        {
            return SwWorkHistoryServiceService.GetSwWorkHistoryById(id);
        }
    }
}
