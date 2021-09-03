

using System.Collections.Generic;

namespace MyPro.Domain.ProjectAgg
{
    public interface IProjectRepository
    {
        List<Project> List();
        void Create(Project project);
        void Save();
        Project GetBy(int id);
    }
}