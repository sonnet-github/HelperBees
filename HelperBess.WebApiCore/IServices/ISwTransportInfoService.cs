using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwTransportInfoService
    {
        IEnumerable<SwTransportInfo> GetSwTransportInfo();
        SwTransportInfo GetSwTransportInfoById(int id);
        SwTransportInfo AddSwTransportInfo(SwTransportInfo SwTransportInfo);
        SwTransportInfo UpdateSwTransportInfo(SwTransportInfo SwTransportInfo);
        SwTransportInfo DeleteSwTransportInfo(int id);
    }
}
