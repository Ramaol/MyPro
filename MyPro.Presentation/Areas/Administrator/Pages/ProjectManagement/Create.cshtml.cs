using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPro.Application.Contract.Project;

namespace MyPro.Presentation.Areas.Administrator.Pages.ProjectManagement
{
    public class Create : PageModel
    {
        
        private readonly IProjectApplication _projetApplication;

        public Create(IProjectApplication projectApplication)
        {
            _projetApplication = projectApplication;
        }
       
        public void OnGet()
        {

        }

        public RedirectToPageResult OnPost(CreateModel command)
        {
            _projetApplication.Create(command);
            return RedirectToPage("./List");
        }

    }
}