using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using MyPro.Application.Contract.ArticleCategury;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using MyPro.Application.Contract.Article;

namespace MyPro.Presentation.Areas.Administrator.Pages.ArticleManagement
{
    public class Create : PageModel
    {

        public List<SelectListItem> ArticleCateguries { get; set; }
        private readonly IArticleCateguryApplication _articleCateguryApplication;
        private readonly IArticleApplication _articleApplication;
        
        public Create(IArticleCateguryApplication articleCateguryApplication , IArticleApplication articleApplication)
        {
            _articleCateguryApplication = articleCateguryApplication;
            _articleApplication = articleApplication;
        }
        public void OnGet()
        {
            ArticleCateguries = _articleCateguryApplication.List().Select( x => new SelectListItem(x.Title , x.Id.ToString())).ToList();
        }

        public RedirectToPageResult OnPost(CreateModel command)
        {
            _articleApplication.Create(command);
            return RedirectToPage("./List");
        }


    }
}