using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwEmergencyContactService
    {
        IEnumerable<SwEmergencyContact> GetSwEmergencyContact();
        SwEmergencyContact GetSwEmergencyContactById(int id);
        SwEmergencyContact AddSwEmergencyContact(SwEmergencyContact SwEmergencyContact);
        SwEmergencyContact UpdateSwEmergencyContact(SwEmergencyContact SwEmergencyContact);
        SwEmergencyContact DeleteSwEmergencyContact(int id);
    }
}
