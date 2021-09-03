
using System.Collections.Generic;

namespace MyPro.Application.Contract.Article
{
    public interface IArticleApplication
    {
        List<ArticleViewModel> GetArticleViewModels();
        void Create(CreateModel command);
        void Edit(EditModel command);
        EditModel GetEditModel(long id);
        void Remove(long id);
        void Activate(long id);
        
    }
}