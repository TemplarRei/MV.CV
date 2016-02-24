namespace MV.CV.Web.Areas.ProfileView.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Services.Data;
    using ViewModels.Projects;

    public class ProjectsController : Controller
    {
        private readonly IProjectServices projects;
        private readonly IProfileServices profiles;

        public ProjectsController(IProjectServices projects, IProfileServices profiles)
        {
            this.projects = projects;
            this.profiles = profiles;
        }

        public ActionResult ProjectsView(string url)
        {
            var profile = this.profiles.GetActiveProfileByUrl(url);

            var projects = this.projects.GetProjectsForPublicProfile(profile.Id).ToList();

            return this.PartialView(new ProjectViewModel { Projects = projects });
        }
    }
}
