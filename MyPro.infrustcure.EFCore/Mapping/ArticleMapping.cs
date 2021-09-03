using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyPro.Domain.ArticleAgg;

namespace MyPro.infrustcure.EFCore.Mapping
{
    public class ArticleMapping : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("Articles");
            builder.HasKey( x => x.Id);
            builder.Property(x => x.Title);
            builder.Property(x => x.ArticleCateguryId);
            builder.Property(x => x.Content );
            builder.Property( x => x.Image);
            builder.Property(x =>x.IsDeleted );
            builder.Property( x => x.CreationDate);

            builder.HasOne( x => x.ArticleCategury).WithMany( x => x.Articles).HasForeignKey( x => x.ArticleCateguryId );
        }
    }
}