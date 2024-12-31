using ContactManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContactManagement.Infraestructure.Data.Map
{
    public class UserContactMap : IEntityTypeConfiguration<UserContact>
    {
        public void Configure(EntityTypeBuilder<UserContact> builder)
        {
            builder.ToTable("UserContact");

            builder.HasKey(x => x.Id);

            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(u => u.PhoneNumber)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasIndex(u => u.Email)
                .IsUnique();
            
            builder.HasOne(u => u.PhoneDDD)
                    .WithMany(p => p.Users)
                    .HasForeignKey(u => u.DDDId);
        }
    }
}

