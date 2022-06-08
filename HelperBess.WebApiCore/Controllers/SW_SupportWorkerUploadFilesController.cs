using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.IO;
using System;

namespace HelperBess.WebApiCore.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]
    public class SW_SupportWorkerUploadFilesController : ControllerBase
    {
        private readonly ISW_SupportWorkerUploadFiles SW_SupportWorkerUploadFilesService;
        public SW_SupportWorkerUploadFilesController(ISW_SupportWorkerUploadFiles iSW_SupportWorkerUploadFilesService)
        {
            SW_SupportWorkerUploadFilesService = iSW_SupportWorkerUploadFilesService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SW_SupportWorkerUploadFiles/GetSW_SupportWorkerUploadFiles")]
        //[Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin": "http://mywebclient.azurewebsites.net", headers: "*", methods: "*")]
        public IEnumerable<SW_SupportWorkerUploadFiles> GetSW_SupportWorkerUploadFiles()
        {
            return SW_SupportWorkerUploadFilesService.GetSW_SupportWorkerUploadFiles();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SW_SupportWorkerUploadFiles/AddSW_SupportWorkerUploadFiles")]
        public SW_SupportWorkerUploadFiles AddSW_SupportWorkerUploadFiles(IFormFile files, int supportworkerid)
        {
            var objfiles = new SW_SupportWorkerUploadFiles();
            if (files != null)
            {
                if (files.Length > 0)
                {
                    var fileName = Path.GetFileName(files.FileName);
                    var fileExtension = Path.GetExtension(fileName);
                    var newFileName = String.Concat(Convert.ToString(Guid.NewGuid()), fileExtension);

                    objfiles = new SW_SupportWorkerUploadFiles()
                    {
                        FileName = newFileName,
                        FileType = fileExtension,
                        CreatedOn = DateTime.Now,
                        SupportWorkerId = supportworkerid
                    };

                    using (var target = new MemoryStream())
                    {
                        files.CopyTo(target);
                        objfiles.DataFiles = target.ToArray();
                    }

                }
            }

            return SW_SupportWorkerUploadFilesService.AddSW_SupportWorkerUploadFiles(objfiles);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SW_SupportWorkerUploadFiles/UpdateSW_SupportWorkerUploadFiles")]
        public SW_SupportWorkerUploadFiles UpdateSW_SupportWorkerUploadFiles(SW_SupportWorkerUploadFiles SW_SupportWorkerUploadFiles)
        {
            return SW_SupportWorkerUploadFilesService.UpdateSW_SupportWorkerUploadFiles(SW_SupportWorkerUploadFiles);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SW_SupportWorkerUploadFiles/DeleteSW_SupportWorkerUploadFiles")]
        public SW_SupportWorkerUploadFiles DeleteSW_SupportWorkerUploadFiles(int id)
        {
            return SW_SupportWorkerUploadFilesService.DeleteSW_SupportWorkerUploadFiles(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SW_SupportWorkerUploadFiles/GetSW_SupportWorkerUploadFilesById")]
        public SW_SupportWorkerUploadFiles GetSW_SupportWorkerUploadFilesById(int id)
        {
            return SW_SupportWorkerUploadFilesService.GetSW_SupportWorkerUploadFilesById(id);
        }
    }
}
