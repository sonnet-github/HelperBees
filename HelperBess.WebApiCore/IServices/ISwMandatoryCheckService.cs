﻿using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwMandatoryCheckService
    {
        IEnumerable<SwMandatoryCheck> GetSwMandatoryCheck();
        SwMandatoryCheck GetSwMandatoryCheckById(int id);
        SwMandatoryCheck AddSwMandatoryCheck(SwMandatoryCheck SwMandatoryCheck);
        SwMandatoryCheck UpdateSwMandatoryCheck(SwMandatoryCheck SwMandatoryCheck);
        SwMandatoryCheck DeleteSwMandatoryCheck(int id);
    }
}
