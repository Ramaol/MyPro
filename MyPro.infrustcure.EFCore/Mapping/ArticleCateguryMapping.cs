using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyPro.Domain.ArticleCateguryAgg;

namespace MyPro.infrustcure.EFCore.Mapping{
    public class ArticleCateguryMapping : IEntityTypeConfiguration<ArticleCategury>
    {
        public void Configure(EntityTypeBuilder<ArticleCategury> builder)
        {
            builder.ToTable("ArticleCateguries");
            
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title);
            builder.Property(x => x.IsDeleted);
            builder.Property(x => x.CreationDate);

            builder.HasMany( x => x.Articles ).WithOne( x => x.ArticleCategury).HasForeignKey( x => x.ArticleCateguryId);
        }
    }
}