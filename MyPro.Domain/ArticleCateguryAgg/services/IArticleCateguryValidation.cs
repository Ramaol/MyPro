

namespace MyPro.Domain.ArticleCateguryAgg.services
{
    public interface IArticleCateguryValidation
    {
        void ChekThisThatRecordAlreadyExist(string title);
    }
}