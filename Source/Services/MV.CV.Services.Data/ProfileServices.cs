namespace MV.CV.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MV.CV.Data.Common;
    using MV.CV.Data.Models;

    public class ProfileServices : IProfileServices
    {
        private readonly IDbRepository<UserProfile> profiles;

        public ProfileServices(IDbRepository<UserProfile> profiles)
        {
            this.profiles = profiles;
        }

        public void AddBasicProfile(UserProfile profile)
        {
            this.profiles.Add(profile);
            this.profiles.Save();
        }

        public UserProfile GetActiveProfileByUrl(string url)
        {
            var profile = this.profiles.All().Where(up => up.Url == url && up.IsActive).FirstOrDefault();

            return profile;
        }
    }
}
