using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IClEmergencyContactService
    {
        IEnumerable<ClEmergencyContact> GetClEmergencyContact();
        ClEmergencyContact GetClEmergencyContactById(int id);
        IEnumerable<ClEmergencyContact> GetClEmergencyContactByParticipantId(int participantid);
        ClEmergencyContact AddClEmergencyContact(ClEmergencyContact ClEmergencyContact);
        ClEmergencyContact UpdateClEmergencyContact(ClEmergencyContact ClEmergencyContact);
        ClEmergencyContact DeleteClEmergencyContact(int id);
    }
}
