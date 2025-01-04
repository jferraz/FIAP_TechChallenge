using ContactManagement.Domain.Entities;

namespace ContactManagement.Domain.DTO
{
    public class UserContactDto : BaseEntity
    {
        public required string Name { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Email { get; set; }
        public int DDDId { get; set; }
    }
}
