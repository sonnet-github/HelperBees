﻿using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelperBess.WebApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SwSupportWorkerController : ControllerBase
    {
        private readonly ISwSupportWorkerService swSupportWorkerService;
        public SwSupportWorkerController(ISwSupportWorkerService swSupportWorker)
        {
            swSupportWorkerService = swSupportWorker;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorker/GetSwSupportWorker")]
        public IEnumerable<SwSupportWorker> GetSwSupportWorker()
        {
            return swSupportWorkerService.GetSwSupportWorker();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/SwSupportWorker/AddSwSupportWorker")]
        public SwSupportWorker AddSwSupportWorker(SwSupportWorker swSupportWorker)
        {
            return swSupportWorkerService.AddSwSupportWorker(swSupportWorker);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/SwSupportWorker/EditSwSupportWorker")]
        public SwSupportWorker EditEmployee(SwSupportWorker swSupportWorker)
        {
            return swSupportWorkerService.UpdateSwSupportWorker(swSupportWorker);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/SwSupportWorker/DeleteSwSupportWorker")]
        public SwSupportWorker DeleteSwSupportWorker(int id)
        {
            return swSupportWorkerService.DeleteSwSupportWorker(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/SwSupportWorker/GetSwSupportWorkerById")]
        public SwSupportWorker GetSwSupportWorkerById(int id)
        {
            return swSupportWorkerService.GetSwSupportWorkerById(id);
        }
    }
}