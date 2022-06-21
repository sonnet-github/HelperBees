using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ICLEmailPreferenceService
    {
        IEnumerable<CLEmailPreference> GetCLEmailPreference();
        CLEmailPreference GetCLEmailPreferenceById(int id);
        IEnumerable<CLEmailPreference> GetCLEmailPreferenceBySupportWorkerId(int supportWorkerId);
        CLEmailPreference AddCLEmailPreference(CLEmailPreference CLEmailPreference);
        CLEmailPreference UpdateCLEmailPreference(CLEmailPreference CLEmailPreference);
        CLEmailPreference DeleteCLEmailPreference(int id);
    }
}
