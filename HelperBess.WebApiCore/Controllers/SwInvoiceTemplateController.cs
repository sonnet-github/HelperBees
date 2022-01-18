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
    public class SwInvoiceTemplateController : ControllerBase
    {
        private readonly ISwInvoiceTemplateService SwInvoiceTemplateServiceService;
        public SwInvoiceTemplateController(ISwInvoiceTemplateService iSwInvoiceTemplateService)
        {
            SwInvoiceTemplateServiceService = iSwInvoiceTemplateService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwInvoiceTemplate/GetSwInvoiceTemplate")]
        public IEnumerable<SwInvoiceTemplate> GetSwInvoiceTemplate()
        {
            return SwInvoiceTemplateServiceService.GetSwInvoiceTemplate();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwInvoiceTemplate/AddSwInvoiceTemplate")]
        public SwInvoiceTemplate AddSwInvoiceTemplate(SwInvoiceTemplate SwInvoiceTemplate)
        {
            return SwInvoiceTemplateServiceService.AddSwInvoiceTemplate(SwInvoiceTemplate);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwInvoiceTemplate/UpdateSwInvoiceTemplate")]
        public SwInvoiceTemplate UpdateSwInvoiceTemplate(SwInvoiceTemplate SwInvoiceTemplate)
        {
            return SwInvoiceTemplateServiceService.UpdateSwInvoiceTemplate(SwInvoiceTemplate);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwInvoiceTemplate/DeleteSwInvoiceTemplate")]
        public SwInvoiceTemplate DeleteSwInvoiceTemplate(int id)
        {
            return SwInvoiceTemplateServiceService.DeleteSwInvoiceTemplate(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwInvoiceTemplate/GetSwInvoiceTemplateById")]
        public SwInvoiceTemplate GetSwInvoiceTemplateById(int id)
        {
            return SwInvoiceTemplateServiceService.GetSwInvoiceTemplateById(id);
        }
    }
}
