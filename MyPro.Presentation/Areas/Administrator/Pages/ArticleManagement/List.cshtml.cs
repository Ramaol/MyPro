using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPro.Application.Contract.Article;

namespace  MyPro.Presentation.Areas.Administrator.Pages.ArticleManagement
{
    public class List : PageModel
    {
        public List<ArticleViewModel> ArticleViewModels { get; set; }
        private readonly IArticleApplication _articleApplication;
        
        public List(IArticleApplication articleApplication)
        {
            _articleApplication =articleApplication;
        }
        public void OnGet()
        {
            ArticleViewModels = _articleApplication.GetArticleViewModels(); 
        }

        public RedirectToPageResult OnPostRemove(long id)
        {
            _articleApplication.Remove(id);
            return RedirectToPage("./List");
        }

        public RedirectToPageResult OnPostActivate(long id)
        {
            _articleApplication.Activate(id);
            return RedirectToPage("./List");
        }

    }
}