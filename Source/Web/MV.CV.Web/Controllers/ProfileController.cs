namespace MV.CV.Web.Controllers
{
    using System.Web.Mvc;
    using Data.Models;
    using Services.Data;
    using ViewModels.Profile;

    public class ProfileController : BaseController
    {
        private readonly IProfileServices profiles;

        public ProfileController(IProfileServices profiles)
        {
            this.profiles = profiles;
        }

        [HttpGet]
        [Authorize]
        public ActionResult Create()
        {
            return this.View();
        }

        [HttpGet]
        public ActionResult ViewProfile(string url)
        {
            var activeProfile = this.profiles.GetActiveProfileByUrl(url);
            return this.View(activeProfile);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateProfileViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                var dbo = this.Mapper.Map<UserProfile>(model);
                dbo.IsActive = true;
                this.profiles.AddBasicProfile(dbo);
            }

            return this.Redirect("/");
        }
    }
}
