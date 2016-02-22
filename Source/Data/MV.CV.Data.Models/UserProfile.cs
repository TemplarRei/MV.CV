namespace MV.CV.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using Common.Models;

    public class UserProfile : BaseModel<int>
    {
        [ForeignKey("User")]
        public string UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<string> Emails => new HashSet<string>();

        public virtual ICollection<Job> Jobs => new HashSet<Job>();

        public virtual ICollection<Education> Education => new HashSet<Education>();

        public virtual ICollection<Project> Projects => new HashSet<Project>();

        public virtual ICollection<Language> Languages => new HashSet<Language>();

        public DateTime Birthday { get; set; }

        public virtual ICollection<Certification> Certifications => new HashSet<Certification>();

        public string SoftSkills { get; set; }

        public string SpecializedSkills { get; set; }
    }
}
