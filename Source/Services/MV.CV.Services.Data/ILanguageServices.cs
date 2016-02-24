namespace MV.CV.Services.Data
{
    using CV.Data.Models;

    public interface ILanguageServices
    {
        void Add(Language language, int profileId);
    }
}
