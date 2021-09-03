using System.Collections.Generic;
using MyPro.Domain.ArticleAgg;
using System.Linq;
using MyPro.Application.Contract.Article;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace MyPro.infrustcure.EFCore.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly BlogContext _Context;
        
        public ArticleRepository(BlogContext context)
        {
            _Context = context;
        }

        public object CaltureInfo { get; private set; }

        public void Create(Article article)
        {
            _Context.Articles.Add(article);
            Save();
        }

        public Article Getby(long id)
        {
            return _Context.Articles.FirstOrDefault( x => x.Id == id);
        }

        public List<ArticleViewModel> List()
        {
            return _Context.Articles.Include( x => x.ArticleCategury).Select( x => new ArticleViewModel{
                Id = x.Id , 
                Title = x.Title , 
                ArticleCategury = x.ArticleCategury.Title ,
                IsDeleted= x.IsDeleted , 
                CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture)
            }).OrderByDescending( x => x.Id).ToList();
        }

        public void Save()
        {
            _Context.SaveChanges();
        }
    }
}