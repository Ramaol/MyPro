
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPro.Application.Contract.Project;

namespace MyPro.Presentation.Areas.Administrator.Pages.ProjectManagement
{    
    public class List : PageModel 
    {
        public List<ProjectViewModel> ProjectViewModels { get; set; }
        private readonly IProjectApplication _projectApplication;
        
        public List(IProjectApplication projectApplication)
        {
            _projectApplication = projectApplication;
        }
        
        public void OnGet()
        {
            ProjectViewModels = _projectApplication.GetProjectViewModel();
        }
        
        public RedirectToPageResult OnPostRemove(int id)
        {
            _projectApplication.Remove(id);
            return RedirectToPage("./List");
        }

        public RedirectToPageResult OnPostActivate(int id)
        {
            _projectApplication.Activate(id);
            return RedirectToPage("./List");
        }
    }
}