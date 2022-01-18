#nullable disable

namespace HelperBess.WebApiCore.Models
{
    public partial class SwAvailability
    {
        public int AvailabilityId { get; set; }
        public int? SupportWorkerId { get; set; }
        public bool? MeetForFree { get; set; }
        public string BasePostcode { get; set; }
        public int? DistanceWillingToTravel { get; set; }
        public int? HoursToTravelFurther { get; set; }
        public decimal? WeekdayRateEarly { get; set; }
        public decimal? WeekdayRateLate { get; set; }
        public decimal? SaturdayRate { get; set; }
        public decimal? SundayRate { get; set; }
        public decimal? Phrate { get; set; }
        public decimal? Weekday12HrRate { get; set; }
        public decimal? Weekday24HrRate { get; set; }
        public bool? RatesNegotiable { get; set; }

        public virtual SwSupportWorker SupportWorker { get; set; }
    }
}
