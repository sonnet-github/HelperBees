using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwReferenceService
    {
        IEnumerable<SwReference> GetSwReference();
        SwReference GetSwReferenceById(int id);

        IEnumerable<SwReference> GetSwReferenceBySWId(int swid);
        SwReference AddSwReference(SwReference SwReference);
        SwReference UpdateSwReference(SwReference SwReference);
        SwReference DeleteSwReference(int id);
    }
}
