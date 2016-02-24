namespace MV.CV.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Common.Models;

    public class UserProfile : BaseModel<int>
    {
        private ICollection<Project> projects;
        private ICollection<Job> jobs;
        private ICollection<Education> education;
        private ICollection<Language> languages;
        private ICollection<Certification> certifications;

        public UserProfile()
        {
            this.projects = new HashSet<Project>();
            this.jobs = new HashSet<Job>();
            this.education = new HashSet<Education>();
            this.languages = new HashSet<Language>();
            this.certifications = new HashSet<Certification>();
        }

        public string UserId { get; set; }

        public bool IsActive { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public DateTime Birthday { get; set; }

        public string Email { get; set; }

        public virtual ICollection<Job> Jobs
        {
            get { return this.jobs; } set { this.jobs = value; }
        }

        public virtual ICollection<Education> Education
        {
            get { return this.education; } set { this.education = value; }
        }

        public virtual ICollection<Project> Projects
        {
            get { return this.projects; } set { this.projects = value; }
        }

        public virtual ICollection<Language> Languages
        {
            get { return this.languages; } set { this.languages = value; }
        }

        public virtual ICollection<Certification> Certifications
        {
            get { return this.certifications; } set { this.certifications = value; }
        }

        public string SoftSkills { get; set; }

        public string SpecializedSkills { get; set; }

        [NotMapped]
        public string Url => $"{this.FirstName}-{this.LastName}";
    }
}
