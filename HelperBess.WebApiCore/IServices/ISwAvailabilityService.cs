﻿using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwAvailabilityService
    {
        IEnumerable<SwAvailability> GetSwAvailability();
        SwAvailability GetSwAvailabilityById(int id);
        SwAvailability AddSwAvailability(SwAvailability SwAvailability);
        SwAvailability UpdateSwAvailability(SwAvailability SwAvailability);
        SwAvailability DeleteSwAvailability(int id);
    }
}
