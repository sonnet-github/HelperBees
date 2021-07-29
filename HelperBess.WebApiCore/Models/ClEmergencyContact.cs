using System;
using System.Collections.Generic;

#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ClEmergencyContact
    {
        public int EmergencyContactId { get; set; }
        public int? ParticipantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string EmailAddress { get; set; }
        public string AddressStreet { get; set; }
        public string AddressPostcode { get; set; }
        public string AddressSuburb { get; set; }
        public string AddressState { get; set; }
        public string Relationship { get; set; }
        public string EmergencyResponseAccessInformation { get; set; }
        public bool? ShareInformation { get; set; }
        public bool? CommuicationAuthority { get; set; }

        public virtual ClParticipant Participant { get; set; }
    }
}
