#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class ClHouseholdDetail
    {
        public int HouseholdDetailsId { get; set; }
        public int? ParticipantId { get; set; }
        public bool? EasyAccess { get; set; }
        public bool? Smokers { get; set; }
        public bool? OffStreetParking { get; set; }
        public bool? EquipmentAvailable { get; set; }
        public string EquipmentDetails { get; set; }
        public string Pets { get; set; }
        public string OtherPets { get; set; }

        public virtual ClParticipant Participant { get; set; }
    }
}
