


namespace MyPro.Application.Contract.Article
{
    public class ArticleViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string CreationDate { get; set; }
        public string ArticleCategury { get; set; }
        public bool IsDeleted { get; set; }
        
    }
}