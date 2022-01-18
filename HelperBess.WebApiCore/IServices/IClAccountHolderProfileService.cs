using HelperBess.WebApiCore.Models;
using System.Collections.Generic;

namespace HelperBess.WebApiCore.IServices
{
    public interface IClAccountHolderProfileService
    {
        IEnumerable<ClAccountHolderProfile> GetClAccountHolderProfile();
        ClAccountHolderProfile GetClAccountHolderProfileById(int id);
        ClAccountHolderProfile AddClAccountHolderProfile(ClAccountHolderProfile ClAccountHolderProfile);
        ClAccountHolderProfile UpdateClAccountHolderProfile(ClAccountHolderProfile ClAccountHolderProfile);
        ClAccountHolderProfile DeleteClAccountHolderProfile(int id);
    }
}
