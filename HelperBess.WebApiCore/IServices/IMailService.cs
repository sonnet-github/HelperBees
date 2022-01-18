using HelperBess.WebApiCore.Models;
using System.Threading.Tasks;

namespace HelperBess.WebApiCore.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
        
    }
}
