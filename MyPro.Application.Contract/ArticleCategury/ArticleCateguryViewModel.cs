using System;

namespace MyPro.Application.Contract.ArticleCategury {
    public class ArticleCateguryViewModel { 
        public long Id { get; set; }
        public string Title { get; set; }
        public string CreationDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}