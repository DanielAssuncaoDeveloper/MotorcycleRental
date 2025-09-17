using MotorcycleRental.Domain.Entities.Common;

namespace MotorcycleRental.Domain.Entities
{
    public class DeliveryManEntity : EntityBase
    {
        public string Name { get; set; } = null!;
        public string Cnpj { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public string DriverLicenseNumber { get; set; } = null!;
        public string DriverLicenseType { get; set; } = null!;
        public string? DriverLicenseImagePath { get; set; }

        public IEnumerable<RentalEntity> Rentals { get; set; } = new List<RentalEntity>();
    }
}
