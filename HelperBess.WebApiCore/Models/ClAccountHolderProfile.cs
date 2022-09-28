using System;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ClAccountHolderProfile
    {
        public int AccountHolderProfileId { get; set; }
        public int? AccountHolderId { get; set; }
        public bool? IsPersonNeedingSupport { get; set; }
        public string RelationshipToPersonNeedingSupport { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string GenderOther { get; set; }
        public string Phone { get; set; }
        public DateTime? Birthdate { get; set; }
        public string AddressStreet { get; set; }
        public string AddressPostcode { get; set; }
        public string AddressSuburb { get; set; }
        public string AddressState { get; set; }
        public string Mobile { get; set; }
        public bool? CareAtThisAddress { get; set; }
        public string LivingWith { get; set; }
        public string LivingWithPerson { get; set; }

        public virtual ClAccountHolder AccountHolder { get; set; }
    }
}
