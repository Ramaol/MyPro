using System;
using MyPro.Domain.ArticleAgg;
using System.Collections.Generic;
using MyPro.Domain.ArticleCateguryAgg.services;

namespace MyPro.Domain.ArticleCateguryAgg {
    public class ArticleCategury {
        public long Id { get; private set; }
        public string Title { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreationDate { get; private set; } 
        public List<Article> Articles { get; private set; }
        
        protected ArticleCategury()
        {

        }

        public ArticleCategury(string title , IArticleCateguryValidation ValidatorService)
        {   
            GuardAgainstemptyTitle(title);
            ValidatorService.ChekThisThatRecordAlreadyExist(title);
            Title = title;
            IsDeleted = false;
            CreationDate = DateTime.Now;
            Articles = new List<Article>();
        }

        public void Delete()
        {
            IsDeleted = true;
        }

        public void Activate()
        {
            IsDeleted = false;
        }

        public void Rename(string title)
        {   
            GuardAgainstemptyTitle(title);
            Title = title;
        }

        public void GuardAgainstemptyTitle(string title)
        {
            if(string.IsNullOrWhiteSpace(title))
                throw new ArgumentNullException();
            
        }
    }       
}