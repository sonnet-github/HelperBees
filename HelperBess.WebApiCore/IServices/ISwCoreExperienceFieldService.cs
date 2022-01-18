using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface ISwCoreExperienceFieldService
    {
        IEnumerable<SwCoreExperienceField> GetSwCoreExperienceField();
        SwCoreExperienceField GetSwCoreExperienceFieldById(int id);
        SwCoreExperienceField AddSwCoreExperienceField(SwCoreExperienceField SwCoreExperienceField);
        SwCoreExperienceField UpdateSwCoreExperienceField(SwCoreExperienceField SwCoreExperienceField);
        SwCoreExperienceField DeleteSwCoreExperienceField(int id);
    }
}
