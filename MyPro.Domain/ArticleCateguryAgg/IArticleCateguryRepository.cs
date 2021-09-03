using System.Collections.Generic;

namespace MyPro.Domain.ArticleCateguryAgg {
    public interface IArticleCateguryRepository {
        void Create(ArticleCategury articleCategury); 
        List<ArticleCategury> GetAll();   
        ArticleCategury Get(long id);  
        void Save();    
        bool Exist(string title);     
    }
}