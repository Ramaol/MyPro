using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPro.infrastructure.Query.ProjectQuery;

namespace MyPro.Presentation.Pages
{
    public class ProjectDetails : PageModel
    {
        public ProjectQueryView Project { get; set; }
        private readonly IProjectQuery _ProjectQuery;
        
        public ProjectDetails(IProjectQuery projectQuery)
        {
            _ProjectQuery = projectQuery;
        }

        public void OnGet(int id)
        {
            Project = _ProjectQuery.GetSingleProject(id);
        }
    }
}
