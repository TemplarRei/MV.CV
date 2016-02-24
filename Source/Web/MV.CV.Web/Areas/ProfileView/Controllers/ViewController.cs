namespace MV.CV.Web.Areas.ProfileView.Controllers
{
    using System.Web.Mvc;

    using Services.Data;
    using ViewModels.Profile;
    using Web.Controllers;

    public class ViewController : BaseController
    {
        private readonly IProfileServices profiles;

        public ViewController(IProfileServices profiles)
        {
            this.profiles = profiles;
        }

        public ActionResult Index(string url)
        {
            var activeProfile = this.Mapper.Map<BasicViewProfileViewModel>(this.profiles.GetActiveProfileByUrl(url));
            return this.View(activeProfile);
        }
    }
}
