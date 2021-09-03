using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyPro.infrastructure.Query.ProjectQuery;

namespace MyPro.Presentation.ViewComponents{ 
        public class ProjectsViewComponent: ViewComponent {

            private readonly IProjectQuery _ProjectQuery;
            public List<ProjectQueryView> Projects { get; set; }
            public ProjectsViewComponent(IProjectQuery projectQuery)
            {
                _ProjectQuery = projectQuery;
            }
            
            public IViewComponentResult Invoke(){
                Projects = _ProjectQuery.GetProject();
                return View(Projects);
            }
        }

}