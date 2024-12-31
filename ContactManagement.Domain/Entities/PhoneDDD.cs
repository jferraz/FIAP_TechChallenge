using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagement.Domain.Entities
{
    public class PhoneDDD : BaseEntity
    {
        public int DDD { get; set; }
        public string? Area { get; set; }
        public required ICollection<UserContact> Users { get; set; }
    }
        
}
