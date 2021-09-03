using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPro.Application.Contract.ArticleCategury;
using Microsoft.AspNetCore.Mvc;

namespace MyPro.Presentation.Areas.Administrator.Pages.ArticleCateguryManagement
{
    public class Create : PageModel 
    {   
        private readonly IArticleCateguryApplication _articleCateguryApplication;

        public Create(IArticleCateguryApplication articleCateguryApplication)
        {
            _articleCateguryApplication = articleCateguryApplication;            
        }
        public void OnGet()
        {
            
        }
        public RedirectToPageResult OnPost(CreateArticleCategury command)
        {
            _articleCateguryApplication.Create(command);
            return RedirectToPage("./List");
        }
    }
}