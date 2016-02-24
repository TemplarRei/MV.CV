namespace MV.CV.Web.ViewModels.Profile
{
    using System;
    using System.ComponentModel;
    using Data.Models;
    using Infrastructure.Mapping;

    public class BasicProfileEditViewModel : IMapFrom<UserProfile>, IMapTo<UserProfile>
    {
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Birthday")]
        public DateTime? Birthday { get; set; }
    }
}
