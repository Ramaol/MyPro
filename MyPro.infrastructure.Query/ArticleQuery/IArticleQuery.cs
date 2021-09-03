using System.Collections.Generic;

namespace MyPro.infrastructure.Query.ArticleQuery
{
    public interface IArticleQuery
    {   
        List<ArticleQueryView> GetArticles();
        ArticleQueryView GetArticle(long id);
        
    }
}