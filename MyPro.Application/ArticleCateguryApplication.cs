using System.Collections.Generic;
using MyPro.Application.Contract.ArticleCategury;
using MyPro.Domain.ArticleCateguryAgg;
using System.Globalization;
using MyPro.Domain.ArticleCateguryAgg.services;
namespace MyPro.Application
{
    public class ArticleCateguryApplication : IArticleCateguryApplication
    {
        private readonly IArticleCateguryRepository _articleCateguryRepository; 
         private readonly IArticleCateguryValidation _articleCateguryValidation;
        
        public ArticleCateguryApplication(IArticleCateguryRepository articleCateguryRepository , IArticleCateguryValidation articleCateguryValidation)
        {
            _articleCateguryRepository = articleCateguryRepository;
            _articleCateguryValidation = articleCateguryValidation;
        }

        public void Activate(long id)
        {
            var ArticleCategury = _articleCateguryRepository.Get(id);
            ArticleCategury.Activate();
            _articleCateguryRepository.Save();
        }

        public void Create(CreateArticleCategury command)
        {
            var ArticleCategury = new ArticleCategury(command.Title , _articleCateguryValidation);
            _articleCateguryRepository.Create(ArticleCategury);
        }

        public RenameArticleCategury GetArticleCategury(long id)
        {
            var ArticleCategury = _articleCateguryRepository.Get(id);
            return new RenameArticleCategury {
                Id = ArticleCategury.Id , 
                Title = ArticleCategury.Title ,
            };
        }

        public List<ArticleCateguryViewModel> List()
        {
            var ArticleCateguries = _articleCateguryRepository.GetAll();
            var Result = new List<ArticleCateguryViewModel>();
            foreach (var item in ArticleCateguries)
            {
                Result.Add(new ArticleCateguryViewModel{
                    Id = item.Id , 
                    Title = item.Title ,
                    IsDeleted = item.IsDeleted ,
                    CreationDate = item.CreationDate.ToString(CultureInfo.InvariantCulture)
                });
            }
            
            return Result;
        }

        public void Remove(long id)
        {
            var ArticleCategury = _articleCateguryRepository.Get(id);
            ArticleCategury.Delete();
            _articleCateguryRepository.Save();
        }

        public void Rename(RenameArticleCategury command)
        {
            var ArticleCategury = _articleCateguryRepository.Get(command.Id);
            ArticleCategury.Rename(command.Title);
            _articleCateguryRepository.Save();
       }
    }
}