namespace MV.CV.Web.ViewModels.Projects
{
    using System;
    using System.Collections.Generic;
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;

    public class ProjectViewModel
    {
        public ICollection<Project> Projects { get; set; }
    }
}
