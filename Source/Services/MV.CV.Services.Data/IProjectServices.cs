namespace MV.CV.Services.Data
{
    using System.Linq;
    using MV.CV.Data.Models;

    public interface IProjectServices
    {
        IQueryable<Project> GetProjectsForProfile(string userId);

        void Update(Project project);

        void Add(Project project, int profileId);

        IQueryable<Project> GetProjectsForPublicProfile(int profileId);
    }
}
