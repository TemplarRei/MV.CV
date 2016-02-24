namespace MV.CV.Services.Data
{
    using System;
    using CV.Data.Models;

    public interface IProfileServices
    {
        void AddBasicProfile(UserProfile profile);

        UserProfile GetActiveProfileByUrl(string url);

        string GetUrlForCurrentUser(string id);

        UserProfile GetActiveProfileByUserId(string id);

        void UpdateBasicInfo(string id, string firstName, string lastName, string email, DateTime? birthday);
    }
}
