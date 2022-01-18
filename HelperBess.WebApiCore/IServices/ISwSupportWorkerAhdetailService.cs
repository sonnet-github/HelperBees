﻿using HelperBess.WebApiCore.Models;
using System.Collections.Generic;


namespace HelperBess.WebApiCore.IServices
{
    public interface ISwSupportWorkerAhdetailService
    {
        IEnumerable<SwSupportWorkerAhdetail> GetSwSupportWorkerAhdetail();
        SwSupportWorkerAhdetail GetSwSupportWorkerAhdetailById(int id);
        SwSupportWorkerAhdetail AddSwSupportWorkerAhdetail(SwSupportWorkerAhdetail SwSupportWorkerAhdetail);
        SwSupportWorkerAhdetail UpdateSwSupportWorkerAhdetail(SwSupportWorkerAhdetail SwSupportWorkerAhdetail);
        SwSupportWorkerAhdetail DeleteSwSupportWorkerAhdetail(int id);
    }
}
