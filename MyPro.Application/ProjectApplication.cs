using System.Collections.Generic;
using MyPro.Application.Contract.Project;
using MyPro.Domain.ProjectAgg;
using System.Globalization;

namespace MyPro.Application
{
    public class ProjectApplication : IProjectApplication
    {
        
        private readonly IProjectRepository _projectRepository;

        public ProjectApplication(IProjectRepository projectRepositor)
        {
            _projectRepository = projectRepositor;
        }

        public void Activate(int id)
        {
            var project = _projectRepository.GetBy(id);
            project.Activate();
            _projectRepository.Save();
        }

        public void Create(CreateModel command)
        {
            var project = new Project(command.Title , command.Image , command.ShortDescription , command.Content);
            _projectRepository.Create(project);
            _projectRepository.Save();
        }

        public void Edit(EditModel command)
        {
            var project = _projectRepository.GetBy(command.Id);
            project.Edit(command.Title , command.ShortDescription, command.Image , command.Content);
            _projectRepository.Save();
        }

        public EditModel GetBy(int id)
        {
            var project = _projectRepository.GetBy(id);
            return new EditModel{
                Title = project.Title ,
                Content = project.Content ,
                Image = project.Image , 
                Id = project.Id , 
                ShortDescription = project.ShortDescription
            };
        }

        public List<ProjectViewModel> GetProjectViewModel()
        {
            List<Project> projects =  _projectRepository.List();
            List<ProjectViewModel> model = new List<ProjectViewModel>();
            
            foreach (var item in projects)
            {
                model.Add(new ProjectViewModel{
                    Id = item.Id ,
                    Title = item.Title , 
                    CreationDate = item.CreationDate.ToString(CultureInfo.InvariantCulture) , 
                    IsDeleted = item.IsDeleted , 
                });
            }

            return model;
        }

        public void Remove(int id)
        {
            var Project = _projectRepository.GetBy(id);
            Project.Remove();
            _projectRepository.Save();
        }
    }
}