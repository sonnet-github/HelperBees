using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwServiceGroupService
    {
        IEnumerable<SwServiceGroup> GetSwServiceGroup();
        SwServiceGroup GetSwServiceGroupById(int id);
        SwServiceGroup AddSwServiceGroup(SwServiceGroup SwServiceGroup);
        SwServiceGroup UpdateSwServiceGroup(SwServiceGroup SwServiceGroup);
        SwServiceGroup DeleteSwServiceGroup(int id);
    }
}
