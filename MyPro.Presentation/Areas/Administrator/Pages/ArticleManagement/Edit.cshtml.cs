using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyPro.Application.Contract.Article;
using MyPro.Application.Contract.ArticleCategury;
using System.Linq;

namespace MyPro.Presentation.Areas.Administrator.Pages.ArticleManagement
{
    public class Edit : PageModel
    {      
        [BindProperty] public EditModel Article { get; set; }
        public List<SelectListItem> ArticleCateguries { get; set; }
        
        private readonly IArticleApplication _articleApplication;
        private readonly IArticleCateguryApplication _articleCateguryApplication;

        public Edit(IArticleApplication articleApplication , IArticleCateguryApplication articleCateguryApplication)
        {
            _articleApplication = articleApplication;
            _articleCateguryApplication = articleCateguryApplication;

        }
        public void OnGet(long id)
        {
            Article = _articleApplication.GetEditModel(id);
            ArticleCateguries = _articleCateguryApplication.List().Select( x => new SelectListItem(x.Title , x.Id.ToString())).ToList();
        }       

        public RedirectToPageResult OnPost()
        {
            _articleApplication.Edit(Article);
            return RedirectToPage("./List");
        } 
    }
}