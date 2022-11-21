using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwClientService
    {
        IEnumerable<SwClient> GetSwClient();
        SwClient GetSwClientById(int id);
        IEnumerable<SwClient> GetSwClientBySupportWorkerId(int id);
        IEnumerable<SwClient> GetSwClientByParticipantId(int id);
        SwClient AddSwClient(SwClient SwClient);
        SwClient UpdateSwClient(SwClient SwClient);
        SwClient DeleteSwClient(int id);
    }
}
