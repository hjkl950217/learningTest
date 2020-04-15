using ColdChain.Entity.BaseInfo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ColdChain.Mapping.BaseInfo
{
    public class AreaMapping : IEntityTypeConfiguration<AreaEntity>
    {
        public void Configure(EntityTypeBuilder<AreaEntity> builder)
        {
            builder.ToTable("Area");
            builder.Property(i => i.Name).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(i => i.AreaLevel).IsRequired();
            builder.Property(i => i.AreaCode).IsRequired();
        }
    }
}