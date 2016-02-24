namespace MV.CV.Web.ViewModels.Profile
{
    using System;
    using System.ComponentModel;
    using System.Linq;

    using AutoMapper;

    using Data.Models;
    using Infrastructure.Mapping;

    public class BasicViewProfileViewModel : IMapFrom<UserProfile>, IMapTo<UserProfile>, IHaveCustomMappings
    {
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Birthday")]
        public DateTime Birthday { get; set; }

        public bool HasJobs { get; set; }

        public bool HasEducation { get; set; }

        public bool HasProjects { get; set; }

        public bool HasLanguages { get; set; }

        public bool HasCertifications { get; set; }

        public bool HasSoftSkills { get; set; }

        public bool HasSpecializedSkills { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<UserProfile, BasicViewProfileViewModel>()
                .ForMember(vmp => vmp.HasJobs, opts => opts.MapFrom(up => up.Jobs.Any()))
                .ForMember(vmp => vmp.HasEducation, opts => opts.MapFrom(up => up.Education.Any()))
                .ForMember(vmp => vmp.HasLanguages, opts => opts.MapFrom(up => up.Languages.Any()))
                .ForMember(vmp => vmp.HasProjects, opts => opts.MapFrom(up => up.Projects.Any()))
                .ForMember(vmp => vmp.HasCertifications, opts => opts.MapFrom(up => up.Certifications.Any()))
                .ForMember(vmp => vmp.HasSoftSkills, opts => opts.MapFrom(up => string.IsNullOrEmpty(up.SoftSkills)))
                .ForMember(vmp => vmp.HasSpecializedSkills, opts => opts.MapFrom(up => string.IsNullOrEmpty(up.SpecializedSkills)));
        }
    }
}
