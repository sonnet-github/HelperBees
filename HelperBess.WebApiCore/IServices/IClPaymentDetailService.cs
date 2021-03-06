using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IClPaymentDetailService
    {
        IEnumerable<ClPaymentDetail> GetClPaymentDetail();
        ClPaymentDetail GetClPaymentDetailById(int id);
        ClPaymentDetail AddClPaymentDetail(ClPaymentDetail ClPaymentDetail);
        ClPaymentDetail UpdateClPaymentDetail(ClPaymentDetail ClPaymentDetail);
        ClPaymentDetail DeleteClPaymentDetail(int id);
    }
}
