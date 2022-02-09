using System;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public class ConnectionString
    {
        public ConnectionString()
        {
        }
        public string DefaultConnection { get; set; }
        public string MainDBConnectionString { get; set; }
    }
}
