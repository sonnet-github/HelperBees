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
    public class SwInvoiceController : ControllerBase
    {
        private readonly ISwInvoiceService SwInvoiceServiceService;
        public SwInvoiceController(ISwInvoiceService iSwInvoiceService)
        {
            SwInvoiceServiceService = iSwInvoiceService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwInvoice/GetSwInvoice")]
        public IEnumerable<SwInvoice> GetSwInvoice()
        {
            return SwInvoiceServiceService.GetSwInvoice();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwInvoice/AddSwInvoice")]
        public SwInvoice AddSwInvoice(SwInvoice SwInvoice)
        {
            return SwInvoiceServiceService.AddSwInvoice(SwInvoice);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwInvoice/UpdateSwInvoice")]
        public SwInvoice UpdateSwInvoice(SwInvoice SwInvoice)
        {
            return SwInvoiceServiceService.UpdateSwInvoice(SwInvoice);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwInvoice/DeleteSwInvoice")]
        public SwInvoice DeleteSwInvoice(int id)
        {
            return SwInvoiceServiceService.DeleteSwInvoice(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwInvoice/GetSwInvoiceById")]
        public SwInvoice GetSwInvoiceById(int id)
        {
            return SwInvoiceServiceService.GetSwInvoiceById(id);
        }
    }
}
