namespace MV.CV.Services.Data
{
    using System;
    using System.Linq;
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
            var profile = this.profiles
                .All()
                .Where(up => (up.FirstName.ToLower() + "-" + up.LastName.ToLower()) == url && up.IsActive)
                .FirstOrDefault();

            return profile;
        }

        public UserProfile GetActiveProfileByUserId(string id)
        {
            var profile = this.profiles.All().Where(up => up.UserId == id && up.IsActive).FirstOrDefault();

            return profile;
        }

        public string GetUrlForCurrentUser(string id)
        {
            var url = this.profiles
                .All()
                .Where(up => (up.UserId == id) && up.IsActive)
                .Select(u => u.FirstName + "-" + u.LastName)
                .FirstOrDefault();

            return url;
        }

        public void UpdateBasicInfo(string id, string firstName, string lastName, string email, DateTime? birthday)
        {
            var toUpdate = this.profiles.All().Where(up => up.UserId == id && up.IsActive).FirstOrDefault();

            if (!string.IsNullOrWhiteSpace(firstName))
            {
                toUpdate.FirstName = firstName;
            }

            if (!string.IsNullOrWhiteSpace(lastName))
            {
                toUpdate.LastName = lastName;
            }

            if (!string.IsNullOrWhiteSpace(email))
            {
                toUpdate.Email = email;
            }

            if (birthday != null)
            {
                toUpdate.Birthday = (DateTime)birthday;
            }

            this.profiles.Update(toUpdate);
        }
    }
}
