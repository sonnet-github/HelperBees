﻿using HelperBess.WebApiCore.Models;
using HelperBess.WebApiCore.Services;
//using MailKit;
//using _101SendEmailNotificationDoNetCoreWebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace HelperBess.WebApiCore.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    [Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]
    public class EmailController : Controller
    {

        private readonly IMailService mailService;
        public EmailController(IMailService mailService)
        {
            this.mailService = mailService;
        }

        [HttpPost("Send")]
        public async Task<IActionResult> Send([FromForm] MailRequest request)
        {
            try
            {
                await mailService.SendEmailAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }
}
