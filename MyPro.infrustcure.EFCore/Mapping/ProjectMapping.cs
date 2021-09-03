using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyPro.Domain.ProjectAgg;

namespace MyPro.infrustcure.EFCore
{
    public class ProjectMapping : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Projects");
            builder.HasKey( x => x.Id);
            builder.Property( x => x.Title);
            builder.Property ( x => x.ShortDescription);
            builder.Property( x => x.Content);
            builder.Property ( x => x.Image);
            builder.Property( x => x.CreationDate );
            
        }
    }
}