namespace MV.CV.Web.ViewModels.Profile
{
    using System;

    using Data.Models;
    using Infrastructure.Mapping;

    public class CreateProfileViewModel : IMapFrom<UserProfile>, IMapTo<UserProfile>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime Birthday { get; set; }
    }
}
