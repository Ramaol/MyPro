using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPro.Application.Contract.ArticleCategury;
using Microsoft.AspNetCore.Mvc;

namespace MyPro.Presentation.Areas.Administrator.Pages.ArticleCateguryManagement
{   

    public class Edit : PageModel 
    {
        [BindProperty] public RenameArticleCategury ArticleCategury { get; set; }
        private readonly IArticleCateguryApplication _articleCateguryApplication;
        public Edit(IArticleCateguryApplication articleCateguryApplication)
        {
            _articleCateguryApplication = articleCateguryApplication;
        }
        public void OnGet(long id)
        {
            ArticleCategury = _articleCateguryApplication.GetArticleCategury(id);
        }

        public RedirectToPageResult OnPost()
        {
            _articleCateguryApplication.Rename(ArticleCategury);
            return RedirectToPage("./List");
        }
    }
}