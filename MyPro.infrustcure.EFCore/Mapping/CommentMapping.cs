using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyPro.Domain.CommentAgg;

namespace MyPro.infrustcure.EFCore.Mapping
{
    public class CommentMapping : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");
            builder.HasKey(x => x.Id);
            builder.Property( x => x.Name);
            builder.Property( x => x.Email);
            builder.Property( x => x.Message);
            builder.Property( x => x.CreationDate);
            builder.Property( x => x.IsRead);
        }
    }
}
