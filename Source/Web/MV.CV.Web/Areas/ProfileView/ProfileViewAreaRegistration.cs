namespace MV.CV.Web.Areas.ProfileView
{
    using System.Web.Mvc;

    public class ProfileViewAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ProfileView";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ProfileView_default",
                "ProfileView/{url}",
                new { controller = "View", action = "Index" });
        }
    }
}
