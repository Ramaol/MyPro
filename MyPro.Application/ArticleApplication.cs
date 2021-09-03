using System.Collections.Generic;
using MyPro.Application.Contract.Article;
using MyPro.Domain.ArticleAgg;

namespace MyPro.Application
{
    public class ArticleApplication : IArticleApplication
    {      
        private readonly IArticleRepository _articleRepository;

        public ArticleApplication(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public void Activate(long id)
        {
            var Article = _articleRepository.Getby(id);
            Article.Activate();
            _articleRepository.Save();
        }

        public void Create(CreateModel command)
        {
            var article = new Article(command.Title , command.ShortDescription , command.Image , command.Content , command.ArticleCategury );
            _articleRepository.Create(article);
        }

        public void Edit(EditModel command)
        {
            var article = _articleRepository.Getby(command.Id);
            article.Edit(command.Title , command.ShortDescription , command.Image , command.Content , command.ArticleCategury);
            _articleRepository.Save();
        }

        public List<ArticleViewModel> GetArticleViewModels()
        {
            return _articleRepository.List();
        }

        public EditModel GetEditModel(long id)
        {
            var article = _articleRepository.Getby(id);
            return new EditModel {
                Title = article.Title , 
                Id = article.Id , 
                ShortDescription = article.ShortDescription , 
                Image = article.Image , 
                Content = article.Content , 
                ArticleCategury = article.ArticleCateguryId 
            }; 
        }

        public void Remove(long id)
        {
            var Article = _articleRepository.Getby(id);
            Article.Remove();
            _articleRepository.Save();
        }
    }
}