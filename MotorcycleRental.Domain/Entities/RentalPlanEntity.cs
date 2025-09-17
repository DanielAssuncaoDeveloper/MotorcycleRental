using MotorcycleRental.Domain.Entities.Common;

namespace MotorcycleRental.Domain.Entities
{
    public class RentalPlanEntity : EntityBase
    {
        public int PlanDays { get; set; }
        public decimal DailyRate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
