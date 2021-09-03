using System.Collections.Generic;


namespace MyPro.Application.Contract.ArticleCategury {
        public interface IArticleCateguryApplication {
            List<ArticleCateguryViewModel> List();
            void Create(CreateArticleCategury command);
            void Rename(RenameArticleCategury command);
            RenameArticleCategury GetArticleCategury(long id);
            void Remove(long id);
            void Activate(long id);
             
        }
}