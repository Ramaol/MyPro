using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyPro.infrastructure.Query.ArticleQuery;

namespace MyPro.Presentation.ViewComponents {
        public class ArticlesViewComponent : ViewComponent {
            
            private readonly IArticleQuery _ArticelQuery;
            public ArticlesViewComponent(IArticleQuery articleQuery)
            {
                _ArticelQuery = articleQuery;
            }
            public IViewComponentResult Invoke(){
                
                List<ArticleQueryView> Articles = _ArticelQuery.GetArticles();
                return View(Articles);
            }
        }
}