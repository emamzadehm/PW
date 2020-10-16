using PW.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PW.Infrastructure.EFCore.Mapping
{
    public class FileMapping : IEntityTypeConfiguration<File>
    {
        public void Configure(EntityTypeBuilder<File> builder)
        {
            builder.ToTable("Files");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FileName);
            builder.Property(x => x.FileTypeId);
            builder.Property(x => x.Description);
            builder.Property(x => x.UploadDate);
            builder.Property(x => x.Status);
        }
    }

}
