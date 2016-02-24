namespace MV.CV.Web.ViewModels.Projects
{
    using System.Collections.Generic;
    using Data.Models;
    using Infrastructure.Mapping;

    public class ProjectViewModel : IMapFrom<UserProfile>
    {
        public ICollection<Project> Projects { get; set; }
    }
}