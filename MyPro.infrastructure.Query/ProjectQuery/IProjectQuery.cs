using System;
using System.Collections.Generic;

namespace MyPro.infrastructure.Query.ProjectQuery
{
    public interface IProjectQuery
    {
        List<ProjectQueryView> GetProject();
        ProjectQueryView GetSingleProject(int id);
    }
}
