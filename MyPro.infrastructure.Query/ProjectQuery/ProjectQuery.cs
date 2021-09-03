using System.Linq;
using System.Collections.Generic;
using MyPro.infrustcure.EFCore;
using System.Globalization;

namespace MyPro.infrastructure.Query.ProjectQuery
{
    public class ProjectQuery : IProjectQuery
    {
        private readonly BlogContext _Context ;
        
        public ProjectQuery(BlogContext context)
        {
            _Context = context;
        }
        
        public List<ProjectQueryView> GetProject()
        {
            return _Context.Projects.Where( x=> x.IsDeleted == false).Select( x => new ProjectQueryView{
                Id = x.Id , 
                Image = x.Image , 
                ShortDescription = x.ShortDescription ,
                CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture) ,
                Title = x.Title 
            }).ToList();            
        }

        public ProjectQueryView GetSingleProject(int id)
        {
            return _Context.Projects.Where( x=> x.IsDeleted == false).Select( x => new ProjectQueryView{
                Id = x.Id , 
                Image = x.Image , 
                ShortDescription = x.ShortDescription ,
                CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture) ,
                Title = x.Title ,
                Content = x.Content
            }).FirstOrDefault( x => x.Id == id); 
        }
    }
}
