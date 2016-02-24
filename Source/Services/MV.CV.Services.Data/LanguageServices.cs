namespace MV.CV.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CV.Data.Common;
    using CV.Data.Models;

    public class LanguageServices : ILanguageServices
    {
        private readonly IDbRepository<Language> languages;
        private readonly IDbRepository<UserProfile> profiles;

        public LanguageServices(IDbRepository<UserProfile> profiles, IDbRepository<Language> languages)
        {
            this.languages = languages;
            this.profiles = profiles;
        }

        public void Add(Language language, int profileId)
        {
            this.profiles.All().Where(x => x.Id == profileId).FirstOrDefault().Languages.Add(language);
            this.languages.Save();
        }
    }
}
