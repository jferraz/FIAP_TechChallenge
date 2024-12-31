using ContactManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace UserManagement.Infrastructure.Data.EntityMapping
{
    public class PhoneDDDMap : IEntityTypeConfiguration<PhoneDDD>
    {
        public void Configure(EntityTypeBuilder<PhoneDDD> builder)
        {            
            builder.ToTable("PhoneDDD");
            
            builder.HasKey(p => p.Id);
            
            builder.Property(p => p.DDD)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(p => p.Area)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}