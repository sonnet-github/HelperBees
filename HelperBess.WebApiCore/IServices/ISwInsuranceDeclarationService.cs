using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwInsuranceDeclarationService
    {
        IEnumerable<SwInsuranceDeclaration> GetSwInsuranceDeclaration();
        SwInsuranceDeclaration GetSwInsuranceDeclarationById(int id);
        SwInsuranceDeclaration AddSwInsuranceDeclaration(SwInsuranceDeclaration SwInsuranceDeclaration);
        SwInsuranceDeclaration UpdateSwInsuranceDeclaration(SwInsuranceDeclaration SwInsuranceDeclaration);
        SwInsuranceDeclaration DeleteSwInsuranceDeclaration(int id);
    }
}
