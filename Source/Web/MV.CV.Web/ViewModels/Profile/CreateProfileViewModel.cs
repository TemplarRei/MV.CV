namespace MV.CV.Web.ViewModels.Profile
{
    using System;
    using System.Collections.Generic;

    using Data.Models;

    public class CreateProfileViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<string> Emails { get; set; }

        public ICollection<Job> Jobs { get; set; }

        public ICollection<Education> Educations { get; set; }

        public ICollection<Project> Projects { get; set; }

        public ICollection<Language> Languages { get; set; }

        public DateTime Birthday { get; set; }

        public ICollection<Certification> Certifications { get; set; }

        public string SoftSkills { get; set; }

        public string SpecializedSkills { get; set; }
    }
}