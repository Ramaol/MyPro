using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MyPro.infrustcure.EFCore;
using System.Linq;
using System.Globalization;

namespace MyPro.infrastructure.Query.ArticleQuery
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly BlogContext _Context ;
        public ArticleQuery(BlogContext context)
        {
            _Context = context;
        }

        public ArticleQueryView GetArticle(long id)
        {
            return _Context.Articles.Where( x => x.IsDeleted == false).Include( x => x.ArticleCategury).Select( x => new ArticleQueryView {
                Id = x.Id ,
                Title = x.Title , 
                ArticleCategury = x.ArticleCategury.Title ,
                CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture) ,
                ShortDescription = x.ShortDescription , 
                Image = x.Image ,
                Content = x.Content
            }).FirstOrDefault( x => x.Id == id);
        }

        public List<ArticleQueryView> GetArticles()
        {
            return _Context.Articles.Where( x => x.IsDeleted==false).Include( x => x.ArticleCategury).Select( x => new ArticleQueryView {
                Id = x.Id ,
                Title = x.Title , 
                ArticleCategury = x.ArticleCategury.Title ,
                CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture) ,
                ShortDescription = x.ShortDescription , 
                Image = x.Image ,
                Content = x.Content
            }).ToList();
        }

  
    }
}
