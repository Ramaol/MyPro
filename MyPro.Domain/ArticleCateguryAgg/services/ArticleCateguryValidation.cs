using MyPro.Domain.ArticleCateguryAgg.Exeptions;


namespace MyPro.Domain.ArticleCateguryAgg.services
{
    public class ArticleCateguryValidation : IArticleCateguryValidation
    {
        private readonly IArticleCateguryRepository _articleCateguryRepository;
    
        public ArticleCateguryValidation(IArticleCateguryRepository articleCateguryRepository)
        {
            _articleCateguryRepository = articleCateguryRepository;
        }
        public void ChekThisThatRecordAlreadyExist(string title)
        {
            if(_articleCateguryRepository.Exist(title))
            {
                throw new DuplicatedCustomExeptios("This Recored Already Existin Database");
            }
        }
    }
}