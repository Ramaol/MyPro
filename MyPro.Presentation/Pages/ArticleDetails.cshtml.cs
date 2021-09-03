using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPro.infrastructure.Query.ArticleQuery;

namespace MyPro.Presentation.Pages
{
    public class ArticleDetails : PageModel
    {
        public ArticleQueryView Article { get; set; }
        private readonly IArticleQuery _articleQuery;
        
        public ArticleDetails(IArticleQuery articleQuery)
        {
            _articleQuery = articleQuery;
        }
        public void OnGet(long id)
        {
            Article  = _articleQuery.GetArticle(id);            
        }
    }
}
