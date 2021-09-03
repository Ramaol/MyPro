using System.Linq;
using System.Collections.Generic;
using MyPro.Domain.ProjectAgg;

namespace MyPro.infrustcure.EFCore.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        
        private readonly BlogContext _Context;

        public ProjectRepository(BlogContext context)
        {
            _Context = context;
        }

        public void Create(Project project)
        {
            _Context.Projects.Add(project);     
        }

        public Project GetBy(int id)
        {
            return _Context.Projects.FirstOrDefault( x => x.Id == id);
        }

        public List<Project> List()
        {
            return _Context.Projects.OrderByDescending( x => x.Id).ToList();
        }

        public void Save()
        {
            _Context.SaveChanges();
        }
    }
}