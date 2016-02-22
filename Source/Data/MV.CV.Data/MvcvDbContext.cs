namespace MV.CV.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using Common.Models;

    using Microsoft.AspNet.Identity.EntityFramework;

    using Models;

    public class MvcvDbContext : IdentityDbContext<User>
    {
        public MvcvDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<UserProfile> UserProfiles { get; set; }

        public IDbSet<Certification> Certifications { get; set; }

        public IDbSet<Education> Educations { get; set; }

        public IDbSet<Job> Jobs { get; set; }

        public IDbSet<Language> Languages { get; set; }

        public IDbSet<Project> Projects { get; set; }

        public static MvcvDbContext Create()
        {
            return new MvcvDbContext();
        }

        public override int SaveChanges()
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges();
        }

        private void ApplyAuditInfoRules()
        {
            // Approach via @julielerman: http://bit.ly/123661P
            foreach (var entry in
                this.ChangeTracker.Entries()
                    .Where(
                        e =>
                        e.Entity is IAuditInfo && ((e.State == EntityState.Added) || (e.State == EntityState.Modified))))
            {
                var entity = (IAuditInfo)entry.Entity;
                if (entry.State == EntityState.Added && entity.CreatedOn == default(DateTime))
                {
                    entity.CreatedOn = DateTime.Now;
                }
                else
                {
                    entity.ModifiedOn = DateTime.Now;
                }
            }
        }
    }
}
