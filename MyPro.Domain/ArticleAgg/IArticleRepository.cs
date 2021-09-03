
using System.Collections.Generic;
using MyPro.Application.Contract.Article;

namespace MyPro.Domain.ArticleAgg
{
    public interface IArticleRepository
    {
        List<ArticleViewModel> List();
        void Create(Article article);
        void Save();
        Article Getby(long id);

    }
}