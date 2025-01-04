namespace ContactManagement.Domain.Entities
{
    public class PhoneDDD : BaseEntity
    {
        public int DDD { get; set; }
        public string? Area { get; set; }
        public required ICollection<UserContact> Users { get; set; }
    }
        
}
