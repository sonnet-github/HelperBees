using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IConfigurationService
    {
        string DbConnectionString { get; }
    }
}
