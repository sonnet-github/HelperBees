using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISW_SupportWorkerUploadFiles
    {
        IEnumerable<SW_SupportWorkerUploadFiles> GetSW_SupportWorkerUploadFiles();
        SW_SupportWorkerUploadFiles GetSW_SupportWorkerUploadFilesById(int id);
        SW_SupportWorkerUploadFiles AddSW_SupportWorkerUploadFiles(SW_SupportWorkerUploadFiles SW_SupportWorkerUploadFiles);
        SW_SupportWorkerUploadFiles UpdateSW_SupportWorkerUploadFiles(SW_SupportWorkerUploadFiles SW_SupportWorkerUploadFiles);
        SW_SupportWorkerUploadFiles DeleteSW_SupportWorkerUploadFiles(int id);
    }
}
