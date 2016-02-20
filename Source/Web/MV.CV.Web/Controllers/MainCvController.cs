namespace MV.CV.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class MainCvController : BaseController
    {
        [HttpGet]
        [Authorize]
        public ActionResult Create()
        {
            return this.View();
        }
    }
}
