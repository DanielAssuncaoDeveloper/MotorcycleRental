using MotorcycleRental.Domain.Entities.Common;

namespace MotorcycleRental.Domain.Entities
{
    public class MotorcycleYearNotificationEntity : EntityBase
    {
        public Guid MotorcycleId { get; set; }
        public string LicensePlate { get; set; } = null!;
        public int Year { get; set; }
        public string Model { get; set; } = null!;
        public string Payload { get; set; } = null!;
        public DateTime ReceivedAtUtc { get; set; }

        public MotorcycleEntity Motorcycle { get; set; } = null!;
    }
}
