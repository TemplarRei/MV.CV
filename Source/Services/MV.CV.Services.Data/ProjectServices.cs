namespace MV.CV.Services.Data
{
    using System;
    using System.Linq;
    using CV.Data.Common;
    using CV.Data.Models;

    public class ProjectServices : IProjectServices
    {
        private readonly IDbRepository<Project> projects;
        private readonly IDbRepository<UserProfile> profiles;

        public ProjectServices(IDbRepository<Project> projects, IDbRepository<UserProfile> profiles)
        {
            this.profiles = profiles;
            this.projects = projects;
        }

        public IQueryable<Project> GetProjectsForProfile(string userId)
        {
            var profileId = this.profiles
                .All()
                .Where(p => p.UserId == userId && p.IsActive)
                .FirstOrDefault()
                .Id;

            var projects = this.projects
                .All()
                .Where(p => p.ProfileId == profileId);

            return projects;
        }

        public void Update(Project project)
        {
            var toUpdate = this.projects.All().Where(p => p.Id == project.Id).FirstOrDefault();

            if (!string.IsNullOrWhiteSpace(project.Name))
            {
                toUpdate.Name = project.Name;
            }

            if (!string.IsNullOrWhiteSpace(project.Description))
            {
                toUpdate.Description = project.Description;
            }

            if (!string.IsNullOrWhiteSpace(project.Url))
            {
                toUpdate.Url = project.Url;
            }

            this.projects.Update(toUpdate);
            this.projects.Save();
        }

        public IQueryable<Project> GetProjectsForPublicProfile(int id)
        {
            var projects = this.projects.All().Where(p => p.Id == id);

            return projects;
        }

        public void Add(Project project, int profileId)
        {
            this.profiles.All().Where(x => x.Id == profileId).FirstOrDefault().Projects.Add(project);
            this.projects.Save();
        }
    }
}
