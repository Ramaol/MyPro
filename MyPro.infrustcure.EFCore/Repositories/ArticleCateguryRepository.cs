
using MyPro.Domain.ArticleCateguryAgg;
using System.Linq;
using System.Collections.Generic;

namespace MyPro.infrustcure.EFCore.Repositories {
        public class ArticleCateguryRepository : IArticleCateguryRepository {
            private readonly BlogContext _Context;

            public ArticleCateguryRepository(BlogContext Context)
            {
                _Context = Context;               
            }

            public void Create(ArticleCategury model)
            {    
                _Context.ArticleCateguries.Add(model);
                _Context.SaveChanges();
            }
            
            public ArticleCategury Get(long id)
            {
                return _Context.ArticleCateguries.FirstOrDefault(x => x.Id == id);
            }
            
            public List<ArticleCategury> GetAll()
            {   
                return _Context.ArticleCateguries.OrderByDescending(x => x.Id).ToList();
            }
            
            public void Save()
            {
                _Context.SaveChanges();
            }
        
            public bool Exist(string title)
            {
                return _Context.ArticleCateguries.Any(x => x.Title == title);    
            }
    }
}