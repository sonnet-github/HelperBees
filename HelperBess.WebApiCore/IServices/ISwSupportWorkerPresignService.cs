using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwSupportWorkerPresignService
    {
        IEnumerable<SwSupportWorkerPresign> GetSwSupportWorkerPresign();
        IEnumerable<SwSupportWorkerPresign> GetSwSupportWorkerPresignByLocation(string location);
        SwSupportWorkerPresign GetSwSupportWorkerPresignById(int id);
        SwSupportWorkerPresign AddSwSupportWorkerPresign(SwSupportWorkerPresign SwSupportWorkerPresign);
        SwSupportWorkerPresign UpdateSwSupportWorkerPresign(SwSupportWorkerPresign SwSupportWorkerPresign);
        SwSupportWorkerPresign DeleteSwSupportWorkerPresign(int id);
    }
}
