﻿using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwSupportWorkerPcdetailService
    {
        IEnumerable<SwSupportWorkerPcdetail> GetSwSupportWorkerPcdetail();
        SwSupportWorkerPcdetail GetSwSupportWorkerPcdetailById(int id);
        SwSupportWorkerPcdetail AddSwSupportWorkerPcdetail(SwSupportWorkerPcdetail SwSupportWorkerPcdetail);
        SwSupportWorkerPcdetail UpdateSwSupportWorkerPcdetail(SwSupportWorkerPcdetail SwSupportWorkerPcdetail);
        SwSupportWorkerPcdetail DeleteSwSupportWorkerPcdetail(int id);
    }
}
