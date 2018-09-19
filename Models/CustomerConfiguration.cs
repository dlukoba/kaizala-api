using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace saf_kaizala_api.Models
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> customerTableBuilder)
        {
            customerTableBuilder.HasKey(ct => ct.Id);
            customerTableBuilder.Property(ct => ct.FirstName).HasMaxLength(20);
            customerTableBuilder.Property(ct => ct.MiddleName).IsRequired(false);
            customerTableBuilder.Property(ct => ct.Surname).HasMaxLength(20);
            customerTableBuilder.Property(ct => ct.IdentificationNumber).HasMaxLength(20)
                .IsRequired(true);
            customerTableBuilder.Property(ct => ct.PhoneNumber).HasMaxLength(20)
                .IsRequired(true);
            customerTableBuilder.ToTable("customers");
        }
    }
}