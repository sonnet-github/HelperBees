using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HelperBess.WebApiCore.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [Microsoft.AspNetCore.Cors.EnableCors("AllowOrigin")]

    public class CulturalBackgroundController : ControllerBase
    {
        private readonly ICulturalBackgroundService CulturalBackgroundServiceService;
        public CulturalBackgroundController(ICulturalBackgroundService iCulturalBackgroundService)
        {
            CulturalBackgroundServiceService = iCulturalBackgroundService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/CulturalBackground/GetCulturalBackground")]
        public IActionResult GetCulturalBackground()
        {
            try
            {
                List<CulturalBackground> culturalBackgrounds = CulturalBackgroundServiceService.GetCulturalBackground().ToList();

                if (culturalBackgrounds != null && culturalBackgrounds.Any())
                {
                    return Ok(culturalBackgrounds);
                }
                else
                {
                    return BadRequest("No cultural backgrounds(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/CulturalBackground/AddCulturalBackground")]
        public IActionResult AddCulturalBackground(CulturalBackground CulturalBackground)
        {
            try
            {
                CulturalBackground culturalBackground = CulturalBackgroundServiceService.AddCulturalBackground(CulturalBackground);

                if (culturalBackground != null)
                {
                    return Ok(culturalBackground);
                }
                else
                {
                    return BadRequest("Failed to add cultural background.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/CulturalBackground/UpdateCulturalBackground")]
        public IActionResult UpdateCulturalBackground(CulturalBackground CulturalBackground)
        {
            try
            {
                CulturalBackground currentCulturalBackground = CulturalBackgroundServiceService.GetCulturalBackgroundById(CulturalBackground.CulturalBackgroundId);

                if (currentCulturalBackground != null)
                {
                    #region Cultural Background to update

                    currentCulturalBackground.CulturalBackgroundId = CulturalBackground.CulturalBackgroundId;
                    currentCulturalBackground.CulturalBackground1 = CulturalBackground.CulturalBackground1;
                    currentCulturalBackground.DisplayOrder = CulturalBackground.DisplayOrder;

                    #endregion

                    CulturalBackground culturalBackground = CulturalBackgroundServiceService.UpdateCulturalBackground(currentCulturalBackground);

                    if (culturalBackground != null)
                    {
                        return Ok(culturalBackground);
                    }
                    else
                    {
                        return BadRequest("Failed to update cultural background.");
                    }
                }
                else
                {
                    return BadRequest("Cultural background not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/CulturalBackground/DeleteCulturalBackground")]
        public IActionResult DeleteCulturalBackground(int id)
        {
            try
            {
                CulturalBackground currentCulturalBackground = CulturalBackgroundServiceService.GetCulturalBackgroundById(id);

                if (currentCulturalBackground != null)
                {
                    CulturalBackground culturalBackground = CulturalBackgroundServiceService.DeleteCulturalBackground(id);

                    return Ok(culturalBackground);
                }
                else
                {
                    return BadRequest("Cultural background not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/CulturalBackground/GetCulturalBackgroundById")]
        public IActionResult GetCulturalBackgroundById(int id)
        {
            try
            {
                CulturalBackground culturalBackground = CulturalBackgroundServiceService.GetCulturalBackgroundById(id);

                if (culturalBackground != null)
                {
                    return Ok(culturalBackground);
                }
                else
                {
                    return BadRequest("Cultural background not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
