using HelperBess.WebApiCore.IServices;
using HelperBess.WebApiCore.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HelperBess.WebApiCore.Services
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly IConfiguration configuration;

        public ConfigurationService(IConfiguration config)
        {
            configuration = config;
        }

        public string DbConnectionString => configuration.GetConnectionString("DbConnection");
    }
}
