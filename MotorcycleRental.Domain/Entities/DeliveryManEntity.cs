using MotorcycleRental.Domain.Entities.Common;
using MotorcycleRental.Domain.Entities.Enum;

namespace MotorcycleRental.Domain.Entities
{
    public class DeliveryManEntity : EntityBase
    {
        public string Name { get; set; } = null!;
        public string Cnpj { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public string DriverLicenseNumber { get; set; } = null!;
        public DriverLicenseType DriverLicenseType { get; set; }
        public string? DriverLicenseImagePath { get; set; }

        public IEnumerable<RentalEntity> Rentals { get; set; } = new List<RentalEntity>();
    }
}
