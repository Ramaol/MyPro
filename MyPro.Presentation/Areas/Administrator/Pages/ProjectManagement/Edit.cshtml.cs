using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPro.Application.Contract.Project;

namespace MyPro.Presentation.Areas.Administrator.Pages.ProjectManagement
{
    public class Edit : PageModel 
    {
       
       
       [BindProperty] public EditModel EditModel { get; set; }
       private readonly IProjectApplication _projectApplication;

       public Edit(IProjectApplication projectApplication)
       {
           _projectApplication = projectApplication;
       }
        public void OnGet(int Id)
        {
            EditModel = _projectApplication.GetBy(Id);
        }
        public RedirectToPageResult OnPost()
        {
            _projectApplication.Edit(EditModel);
            return RedirectToPage("./List");
        }
    }
}