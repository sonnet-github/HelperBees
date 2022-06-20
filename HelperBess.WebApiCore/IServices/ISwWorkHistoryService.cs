using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwWorkHistoryService
    {
        IEnumerable<SwWorkHistory> GetSwWorkHistory();
        SwWorkHistory GetSwWorkHistoryById(int id);
        IEnumerable<SwWorkHistory> GetSwWorkHistoryBySWId(int swid);
        SwWorkHistory AddSwWorkHistory(SwWorkHistory SwWorkHistory);
        SwWorkHistory UpdateSwWorkHistory(SwWorkHistory SwWorkHistory);
        SwWorkHistory DeleteSwWorkHistory(int id);
    }
}
