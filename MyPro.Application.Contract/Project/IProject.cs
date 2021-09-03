

using System.Collections.Generic;

namespace MyPro.Application.Contract.Project
{
    public interface IProjectApplication
    {
        List<ProjectViewModel> GetProjectViewModel();
        void Create(CreateModel command);
        EditModel GetBy(int id);
        void Edit(EditModel command);
        void Remove(int id);
        void Activate(int id);
    }
}