using MotorcycleRental.Domain.Entities.Common;

namespace MotorcycleRental.Domain.Entities
{
    public class RentalEntity : EntityBase
    {
        public Guid DeliveryManId { get; set; }
        public Guid MotorcycleId { get; set; }

        public int PlanDays { get; set; }
        public decimal DailyRate { get; set; }

        public decimal GrossAmount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal FineAmount { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime ExpectedEndDate { get; set; }
        public DateTime EndDate { get; set; }

        public DeliveryManEntity DeliveryMan { get; set; } = null!;
        public MotorcycleEntity Motorcycle { get; set; } = null!;
    }
}
