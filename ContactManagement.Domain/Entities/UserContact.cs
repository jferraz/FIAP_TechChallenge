namespace ContactManagement.Domain.Entities
{
    public class UserContact : BaseEntity
    {        
        public required string Name { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Email { get; set; }
        public int DDDId { get; set; }  
        public virtual required PhoneDDD PhoneDDD { get; set; }

    }
}
