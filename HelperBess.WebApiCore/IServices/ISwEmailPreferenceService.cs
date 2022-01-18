using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwEmailPreferenceService
    {
        IEnumerable<SwEmailPreference> GetSwEmailPreference();
        SwEmailPreference GetSwEmailPreferenceById(int id);
        SwEmailPreference GetSwEmailPreferenceBySupportWorkerId(int supportWorkerId);
        SwEmailPreference AddSwEmailPreference(SwEmailPreference SwEmailPreference);
        SwEmailPreference UpdateSwEmailPreference(SwEmailPreference SwEmailPreference);
        SwEmailPreference DeleteSwEmailPreference(int id);
    }
}
