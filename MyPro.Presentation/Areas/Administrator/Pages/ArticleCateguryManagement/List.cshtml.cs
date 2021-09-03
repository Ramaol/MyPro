using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPro.Application.Contract.ArticleCategury;
using System.Collections.Generic;


namespace MyPro.Presentation.Areas.Administrator.Pages.ArticleCateguryManagement {
    public class List : PageModel 
    {
        public List<ArticleCateguryViewModel> ArticleCateguryViewModels { set ; get ;}
        private IArticleCateguryApplication _articleCateguryApplication;
        
        public List(IArticleCateguryApplication articleCateguryApplication)
        {
            _articleCateguryApplication = articleCateguryApplication;
        }
        public void OnGet()
        {
            ArticleCateguryViewModels = _articleCateguryApplication.List();
        }

        public RedirectToPageResult OnPostRemove(long id)
        {
            _articleCateguryApplication.Remove(id);  
            return RedirectToPage("./List");      
        }

        public RedirectToPageResult OnPostActivate(long id)
        {   
            _articleCateguryApplication.Activate(id);
            return RedirectToPage("./List");
        }
        
    }
}