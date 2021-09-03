using Microsoft.EntityFrameworkCore;
using MyPro.Domain.ArticleCateguryAgg;
using MyPro.infrustcure.EFCore.Mapping; 
using MyPro.Domain.ArticleAgg;
using MyPro.Domain.ProjectAgg;
using MyPro.Domain.CommentAgg;

namespace MyPro.infrustcure.EFCore {    
        public class BlogContext : DbContext {  
            
            public DbSet<ArticleCategury> ArticleCateguries { get; set; }
            public DbSet<Article> Articles { get; set; }
            public DbSet<Project> Projects { get; set; }
            public DbSet<Comment> Comments { get; set; }

            public BlogContext(DbContextOptions<BlogContext> options) : base(options){
                
            }
            
            protected override void OnModelCreating(ModelBuilder modelBuilder){
                modelBuilder.ApplyConfiguration(new ArticleCateguryMapping());
                modelBuilder.ApplyConfiguration(new ArticleMapping());
                modelBuilder.ApplyConfiguration(new ProjectMapping());
                modelBuilder.ApplyConfiguration(new CommentMapping());
                base.OnModelCreating(modelBuilder);
            }

        }
}