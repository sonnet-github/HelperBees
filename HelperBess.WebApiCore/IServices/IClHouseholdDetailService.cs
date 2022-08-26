using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IClHouseholdDetailService
    {
        IEnumerable<ClHouseholdDetail> GetClHouseholdDetail();
        ClHouseholdDetail GetClHouseholdDetailById(int id);
        IEnumerable<ClHouseholdDetail> GetClHouseholdDetailByParticipantId(int participantid);
        ClHouseholdDetail AddClHouseholdDetail(ClHouseholdDetail ClHouseholdDetail);
        ClHouseholdDetail UpdateClHouseholdDetail(ClHouseholdDetail ClHouseholdDetail);
        ClHouseholdDetail DeleteClHouseholdDetail(int id);
    }
}
