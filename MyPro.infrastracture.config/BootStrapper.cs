using Microsoft.Extensions.DependencyInjection;
using MyPro.infrustcure.EFCore.Repositories;
using MyPro.Application.Contract.ArticleCategury;
using MyPro.Application;
using MyPro.Domain.ArticleCateguryAgg;
using MyPro.infrustcure.EFCore;
using Microsoft.EntityFrameworkCore;
using MyPro.Domain.ArticleAgg;
using MyPro.Application.Contract.Article;
using MyPro.Domain.ArticleCateguryAgg.services;
using MyPro.Application.Contract.Project;
using MyPro.Domain.ProjectAgg;
using MyPro.infrastructure.Query.ArticleQuery;
using MyPro.infrastructure.Query.ProjectQuery;
using MyPro.Application.Contract.Comment;
using MyPro.Domain.CommentAgg;

namespace MyPro.infrastracture.config
{
    public class BootStrapper
    {
        public static void Config(IServiceCollection services , string connectionString)
        {
            services.AddTransient<IArticleCateguryApplication , ArticleCateguryApplication>();
            services.AddTransient<IArticleCateguryRepository , ArticleCateguryRepository>();
            services.AddTransient<IArticleRepository , ArticleRepository>();
            services.AddTransient<IArticleApplication , ArticleApplication>();
            services.AddTransient<IArticleCateguryValidation , ArticleCateguryValidation>();
            services.AddTransient<IProjectApplication , ProjectApplication>();
            services.AddTransient<IProjectRepository , ProjectRepository>();
            services.AddTransient<IArticleQuery , ArticleQuery>();
            services.AddTransient<IProjectQuery  , ProjectQuery>();
            services.AddTransient<ICommentApplication , CommentApplication>();
            services.AddTransient<ICommentRepository , CommentRepository>();
            services.AddDbContext<BlogContext>( x => x.UseSqlServer(connectionString , b => b.MigrationsAssembly("MyPro.Presentation") ));
        }
    }
}
