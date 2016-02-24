namespace MV.CV.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Data.Models;
    using Microsoft.AspNet.Identity;

    using Services.Data;
    using ViewModels.Projects;

    public class EditProjectsController : BaseController
    {
        private readonly IProjectServices projects;
        private readonly IProfileServices profiles;

        public EditProjectsController(IProjectServices projects, IProfileServices profiles)
        {
            this.projects = projects;
            this.profiles = profiles;
        }

        [HttpGet]
        public ActionResult EditProjects()
        {
            var projects = this.projects.GetProjectsForProfile(this.User.Identity.GetUserId()).ToList();
            return this.View(new ProjectViewModel { Projects = projects });
        }

        [HttpPost]
        [Authorize]
        public ActionResult EditProject(Project project)
        {
            this.projects.Update(project);
            var projects = this.projects.GetProjectsForProfile(this.User.Identity.GetUserId()).ToList();
            return this.View("EditProjects", new ProjectViewModel { Projects = projects });
        }

        [HttpGet]
        [Authorize]
        public ActionResult AddProject()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult AddProject(Project project)
        {
            if (this.ModelState.IsValid)
            {
                var profile = this.profiles.GetActiveProfileByUserId(this.User.Identity.GetUserId());

                this.projects.Add(project, profile.Id);
            }

            return this.RedirectToAction("Edit", "Profile");
        }
    }
}
