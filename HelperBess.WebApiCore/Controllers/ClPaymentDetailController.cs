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
        public IActionResult GetClPaymentDetail()
        {
            try
            {
                List<ClPaymentDetail> paymentDetails = ClPaymentDetailServiceService.GetClPaymentDetail().ToList();

                if (paymentDetails != null && paymentDetails.Any())
                {
                    return Ok(paymentDetails);
                }
                else
                {
                    return BadRequest("No payment detail(s) available.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/ClPaymentDetail/AddClPaymentDetail")]
        public IActionResult AddClPaymentDetail(ClPaymentDetail ClPaymentDetail)
        {
            try
            {
                ClPaymentDetail paymentDetail = ClPaymentDetailServiceService.AddClPaymentDetail(ClPaymentDetail);

                if (paymentDetail != null)
                {
                    return Ok(paymentDetail);
                }
                else
                {
                    return BadRequest("Failed to add payment detail.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/ClPaymentDetail/UpdateClPaymentDetail")]
        public IActionResult UpdateClPaymentDetail(ClPaymentDetail ClPaymentDetail)
        {
            try
            {
                ClPaymentDetail currentPaymentDetail = ClPaymentDetailServiceService.GetClPaymentDetailById(ClPaymentDetail.PaymentDetailsId);

                if (currentPaymentDetail != null)
                {
                    #region Payment Detail to update

                    currentPaymentDetail.PaymentDetailsId = ClPaymentDetail.PaymentDetailsId;
                    currentPaymentDetail.ParticipantId = ClPaymentDetail.ParticipantId;
                    currentPaymentDetail.GovernmentFunding = ClPaymentDetail.GovernmentFunding;
                    currentPaymentDetail.FundingType = ClPaymentDetail.FundingType;
                    currentPaymentDetail.FundingTypeOther = ClPaymentDetail.FundingTypeOther;
                    currentPaymentDetail.FundingTypeOther = ClPaymentDetail.FundingTypeOther;
                    currentPaymentDetail.PlanType = ClPaymentDetail.PlanType;
                    currentPaymentDetail.HomeCarePackageProviderName = ClPaymentDetail.HomeCarePackageProviderName;
                    currentPaymentDetail.OtherFundingDocument1 = ClPaymentDetail.OtherFundingDocument1;
                    currentPaymentDetail.OtherFundingDocument2 = ClPaymentDetail.OtherFundingDocument2;
                    currentPaymentDetail.OtherFundingDocument3 = ClPaymentDetail.OtherFundingDocument3;
                    currentPaymentDetail.PaymentType = ClPaymentDetail.PaymentType;
                    currentPaymentDetail.CreditCardAuthority = ClPaymentDetail.CreditCardAuthority;
                    currentPaymentDetail.Ccname = ClPaymentDetail.Ccname;
                    currentPaymentDetail.Ccnumber = ClPaymentDetail.Ccnumber;
                    currentPaymentDetail.CcexpiryDate = ClPaymentDetail.CcexpiryDate;
                    currentPaymentDetail.Cccvv = ClPaymentDetail.Cccvv;
                    currentPaymentDetail.BankAccountName = ClPaymentDetail.BankAccountName;
                    currentPaymentDetail.BankName = ClPaymentDetail.BankName;
                    currentPaymentDetail.Bsb = ClPaymentDetail.Bsb;
                    currentPaymentDetail.AccountNumber = ClPaymentDetail.AccountNumber;
                    currentPaymentDetail.DirectDebitAuthorisationForm = ClPaymentDetail.DirectDebitAuthorisationForm;

                    #endregion

                    ClPaymentDetail paymentDetail = ClPaymentDetailServiceService.UpdateClPaymentDetail(currentPaymentDetail);

                    if (paymentDetail != null)
                    {
                        return Ok(paymentDetail);
                    }
                    else
                    {
                        return BadRequest("Failed to update payment detail.");
                    }
                }
                else
                {
                    return BadRequest("Payment detail not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/ClPaymentDetail/DeleteClPaymentDetail")]
        public IActionResult DeleteClPaymentDetail(int id)
        {
            try
            {
                ClPaymentDetail currentPaymentDetail = ClPaymentDetailServiceService.GetClPaymentDetailById(id);

                if (currentPaymentDetail != null)
                {
                    ClPaymentDetail paymentDetail = ClPaymentDetailServiceService.DeleteClPaymentDetail(id);

                    return Ok(paymentDetail);
                }
                else
                {
                    return BadRequest("Payment detail not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/ClPaymentDetail/GetClPaymentDetailById")]
        public IActionResult GetClPaymentDetailById(int id)
        {
            try
            {
                ClPaymentDetail paymentDetail = ClPaymentDetailServiceService.GetClPaymentDetailById(id);

                if (paymentDetail != null)
                {
                    return Ok(paymentDetail);
                }
                else
                {
                    return BadRequest("Payment detail not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
