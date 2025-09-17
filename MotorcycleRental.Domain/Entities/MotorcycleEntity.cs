using MotorcycleRental.Domain.Entities.Common;

namespace MotorcycleRental.Domain.Entities
{
    public class MotorcycleEntity : EntityBase
    {
        public int Year { get; set; }
        public string Model { get; set; } = null!;
        public string LicensePlate { get; set; } = null!;

        public IEnumerable<RentalEntity> Rentals { get; set; } = new List<RentalEntity>();
    }
}
