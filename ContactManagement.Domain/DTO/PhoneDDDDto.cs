using ContactManagement.Domain.Entities;

namespace ContactManagement.Domain.DTO
{
    public class PhoneDDDDto : BaseEntity
    {
        public int DDD { get; set; }
        public string? Area { get; set; }
    }
}
